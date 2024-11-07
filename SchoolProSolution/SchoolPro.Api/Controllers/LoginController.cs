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
                AccessToken? userAccessToken = SetAccessToken(client, school, user).Result;

                if (userAccessToken != null)
                {
                    //Insere log
                    await _systemLogHelper!.LogInformation(user.Id, "Login iniciado por " + user.Name + " (" + user.Id + ")");

                    //Atualiza o access token do usuário
                    user.AccessTokenId = userAccessToken.Id;
                    user.AccessToken = userAccessToken;

                    await _unitOfWork.UserRepository.Update(user);

                    _unitOfWork.CommitAsync().Wait();

                    //Armazena dados do usuário em session 
                    SessionConfiguration sessionConfiguration = new SessionConfiguration
                    {
                        LoggedUserId = user.Id,
                        LoggedClientId = client.Id,
                        LoggedSchoolId = school.Id,
                        ClientSchoolKey = userAccessToken.ClientSchoolKey!.ToString(),
                        SessionCreatedAt = DateTime.UtcNow,
                        SessionLastAt = DateTime.UtcNow,
                        AccessToken = userAccessToken,
                    };

                    SessionConfigurationHandler.SaveSessionConfiguration(user!.Id!, sessionConfiguration);

                    //Salvo o Id do usuário em sessão, para permitir recuperar a SessionConfiguration do usuário
                    HttpContext.Session.SetString("UserId", user.Id.ToString());

                    await _systemLogHelper!.LogInformation(user.Id, "Acesso de " + user.Name + " (" + user.Id + ") realizado com sucesso. " + user.Name);

                    //Prepara o response
                    var response = _mapper!.Map<LoginResponse>(user);
                    var accessToken = _mapper.Map<AccessTokenResponse>(userAccessToken);

                    response.Id = user.Id;
                    response.AccessToken = accessToken;

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
            try
            {
                var userId = HttpContext.Session.GetString("UserId");

                if (!string.IsNullOrEmpty(userId))
                {
                    SessionConfiguration? session = SessionConfigurationHandler.GetSessionConfiguration(Guid.Parse(userId!));

                    if(session != null)
                    {
                        var user = _unitOfWork!.UserRepository.GetById(session.LoggedUserId).Result;

                        if(user != null)
                        {
                            user.AccessToken = null;

                            await _unitOfWork!.AccessTokenRepository.DeleteLoggedUserAccessToken(user.Id);

                            SessionConfigurationHandler.ClearSessionConfiguration(user!.Id!);

                            HttpContext.Items.Remove("UserId");

                            var response = _mapper!.Map<LoginResponse>(user);

                            _unitOfWork.CommitAsync().Wait();

                            return Ok(ResponseFactory<LoginResponse>.Success("Usuário deslogado com sucesso.", response));
                        }
                        else
                        {
                            return StatusCode(StatusCodes.Status404NotFound, ResponseFactory<LoginResponse>.Error("Usuário inexistente."));
                        }
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound, ResponseFactory<LoginResponse>.Error("Sessão de usuário inexistente."));
                    }
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
                var newToken = JwtAuth.GenerateToken(user, combinedKeys);

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

                    var sessionConfiguration = SessionConfigurationHandler.GetSessionConfiguration(user.Id);

                    if (sessionConfiguration != null)
                    {
                        sessionConfiguration.AccessToken = result;
                        SessionConfigurationHandler.UpdateSessionConfiguration(user.Id, sessionConfiguration);
                    }

                    accessToken = result;
                }
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "SetAccessToken");
                throw;
            }

            return accessToken!;
        }
    }
}
