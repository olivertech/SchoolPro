namespace SchoolPro.Api.Controllers
{
    public class LoginController : Base.ControllerBase
    {
        private const string _msgPrefixError = "Request inválido! - ";
        private readonly ILogger<LoginController>? _logger;
        private readonly IValidator<LoginRequest> _validator;

        public LoginController(IUnitOfWork unitOfWork,
                               IMapper? mapper,
                               IConfiguration configuration,
                               ILogger<LoginController>? logger,
                               IValidator<LoginRequest> validator,
                               ISystemLogHelper? systemLogHelper)
            : base(unitOfWork, mapper, configuration, systemLogHelper)
        {
            _nomeEntidade = "Login";
            _logger = logger;
            _validator = validator;
        }

        [HttpPost]
        [Route(nameof(Auth))]
        [Produces("application/json")]
        [AllowAnonymous]
        public async Task<IActionResult> Auth([FromBody] LoginRequest request)
        {
            try
            {
                //Valida os dados do request
                var validation = await _validator.ValidateAsync(request);

                if (!validation.IsValid)
                {
                    _logger!.LogWarning(_msgPrefixError + validation.Errors);
                    return BadRequest(new { Message = validation.Errors });
                }

                if (request is null)
                    return BadRequest(new { Message = "Request inválido!" });

                //Valida os dados de login
                var user = await _unitOfWork!.UserRepository.ValidateLogin(request!.Email!, request!.Password!);

                if (user == null)
                    return BadRequest(new { Message = "Email e/ou senha inválido(s)!" });

                //Verifica se o escola associado ao usuário existe
                var school = _unitOfWork.SchoolRepository.GetList(x => x.Id == user.SchoolId).Result!.FirstOrDefault();

                if (school == null)
                    return BadRequest(new { Message = "Request inválido!" });

                //Recupera o cliente no qual a escola acima está ligada
                var client = _unitOfWork.ClientRepository.GetList(x => x.Id == school.ClientId).Result!.FirstOrDefault();

                if (client == null)
                    return BadRequest(new { Message = "Request inválido!" });

                //Gera token de acesso
                AccessToken? userToken = SetAccessToken(client, school, user).Result;

                if (userToken != null)
                {
                    //Insere log
                    await _systemLogHelper!.LogInformation(user.Id, "Login iniciado por " + user.Name + " (" + user.Id + ")");

                    //Atualiza o access token do usuário
                    user.AccessTokenId = userToken.Id;
                    user.AccessToken = userToken;

                    await _unitOfWork.UserRepository.Update(user);

                    //Prepara o response
                    var response = _mapper!.Map<LoginResponse>(user);

                    response.Id = user.Id;
                    response.Role = user!.Role!;
                    response.AccessToken = userToken;

                    _unitOfWork.CommitAsync().Wait();

                    //Armazena dados do usuário em session 
                    HttpContext.Session.SetString("LoggedUserId", user.Id.ToString());
                    HttpContext.Session.SetString("LoggedSchoolId", school.Id.ToString());
                    HttpContext.Session.SetString("LoggedClientId", client.Id.ToString());
                    HttpContext.Session.SetString("ClientSchoolKey", userToken.ClientSchoolKey!.ToString());

                    await _systemLogHelper!.LogInformation(user.Id, "Acesso de " + user.Name + " (" + user.Id + ") realizado com sucesso. " + user.Name);

                    return Ok(ResponseFactory<LoginResponse>.Success("Acesso realizado com sucesso.", response));
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ResponseFactory<LoginResponse>.Error("Não foi possível gerar o token de acesso!"));
                }
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "Auth");
                return BadRequest(new { Message = "Não foi possível autenticar o acesso. Ocorreu algum erro interno na aplicação, por favor tente novamente. Caso não consiga, informe o suporte." });
            }
        }

        [HttpPost]
        [Route(nameof(Logout))]
        [Produces("application/json")]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            User? user;
            string? userId = HttpContext.Session.GetString("LoggedUserId");

            try
            {
                if (userId != null)
                {
                    user = await _unitOfWork!.UserRepository.GetById(Guid.Parse(userId));
                    user!.AccessTokenId = null;

                    await _unitOfWork!.AccessTokenRepository.DeleteLoggedUserAccessToken(user.Id);

                    //Remove todas as variáveis de sessão do usuário logado
                    HttpContext.Session.Remove("LoggedUserId");
                    HttpContext.Session.Remove("LoggedSchoolId");
                    HttpContext.Session.Remove("LoggedClientId");
                    HttpContext.Session.Remove("ClientSchoolKey");

                    var response = _mapper!.Map<LoginResponse>(user);

                    return Ok(ResponseFactory<LoginResponse>.Success("Usuário deslogado com sucesso.", response));
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ResponseFactory<LoginResponse>.Error("Erro ao deslogar corretamente o usuário. Tente novamente. Se persistir o erro, informe o suporte."));
                }
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "Logout");
                return BadRequest(new { Message = "Não foi possível realizar o logout!" });
            }
        }

        /// <summary>
        /// Método responsável por criar os dados de acesso,
        /// com novo token gerado para o usuário
        /// </summary>
        /// <param name="client"></param>
        /// <param name="school"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        private async Task<AccessToken> SetAccessToken(Client client, School school, User user)
        {
            AccessToken? accessToken = null;
            string combinedKeys = string.Join(".", new[] { client.ClientSecretKey, school.SchoolSecretKey });

            try
            {
                //Gera um novo token de acesso
                var newToken = JwtAuth.GenerateToken(user, client);

                AccessToken newUserToken = new AccessToken
                {
                    Token = newToken.Token,
                    ExpiringAt = newToken.ExpirationDate,
                    CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                    TimedAt = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss")),
                    IsActive = true,
                    ClientSchoolKey = combinedKeys
                };

                //Tenta recuperar o Token associado ao usuário
                var result = _unitOfWork!.AccessTokenRepository.GetToken(user).Result;

                if (result == null)
                {
                    //Se não existir registro de token associado ao usuário, insere
                    accessToken = await _unitOfWork.AccessTokenRepository.Insert(newUserToken, combinedKeys);
                }
                else
                {
                    //Se existir, atualiza o token associado ao usuário
                    result.Token = newToken.Token;
                    result.ExpiringAt = newToken.ExpirationDate;
                    result.CreatedAt = DateOnly.FromDateTime(DateTime.Now);
                    result.TimedAt = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss"));
                    result.IsActive = true;
                    result.ClientSchoolKey = combinedKeys;

                    await _unitOfWork.AccessTokenRepository.Update(result, combinedKeys);

                    accessToken = result;
                }
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "SetAccessToken");
                throw ex;
            }

            return accessToken!;
        }
    }
}
