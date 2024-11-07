namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response que retorna apenas algumas propriedades do user
    /// confirmando o seu login junto com o token de acesso
    /// </summary>
    public class LoginResponse : IResponse
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public RoleResponse? Role { get; set; }
        public AccessTokenResponse? AccessToken { get; set; }
    }
}
