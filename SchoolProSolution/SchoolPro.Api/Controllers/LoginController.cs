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
                               IValidator<LoginRequest> validator)
            : base(unitOfWork, mapper, configuration)
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

                //Verifica se o cliente associado ao usuário existe
                var client = _unitOfWork.ClientRepository.GetList(x => x.Id == user.ClientId).Result!.FirstOrDefault();

                if (client == null)
                    return BadRequest(new { Message = "Request inválido!" });

                //Gera token de acesso
                var userToken = SetAccessToken(client, user);

                //Insere log de acesso do usuário
                await _unitOfWork.LogAccessRepository.Insert(new LogAccess()
                {
                    UserId = user.Id,
                    CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                    TimedAt = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss")),
                    IsActive = true,
                });

                //Prepara o response
                var response = _mapper!.Map<LoginResponse>(user);

                response.Id = user.Id;
                response.Role = user!.Role!;
                response.AccessToken = userToken.Result;

                _unitOfWork.CommitAsync().Wait();

                return Ok(ResponseFactory<LoginResponse>.Success("Acesso realizado com sucesso.", response));
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "Auth");
                return BadRequest(new { Message = "Não foi possível autenticar o acesso. Ocorreu algum erro interno na aplicação, por favor tente novamente. Caso não consiga, informe o suporte." });
            }
        }

        /// <summary>
        /// Método responsável por criar os dados de acesso,
        /// com novo token gerado para o usuário
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        private async Task<AccessToken> SetAccessToken(Client client, User user)
        {
            AccessToken? accessToken = null;

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
                    IsActive = true
                };

                //Tenta recuperar o Token associado ao usuário
                var result = _unitOfWork!.AccessTokenRepository.GetToken(user).Result;

                if (result == null)
                    //Se não existir registro de token associado ao usuário, insere
                    accessToken = await _unitOfWork.AccessTokenRepository.Insert(newUserToken);
                else
                {
                    //Se existir, atualiza o token associado ao usuário
                    result.Token = newToken.Token;
                    result.ExpiringAt = newToken.ExpirationDate;
                    result.CreatedAt = DateOnly.FromDateTime(DateTime.Now);
                    result.TimedAt = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss"));
                    result.IsActive = true;

                    await _unitOfWork.AccessTokenRepository.Update(result);
                    accessToken = result;
                }
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "SetAccessToken");
            }

            return accessToken!;
        }
    }
}
