namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Classe que guarda os tokens de autorização 
    /// dos usuários que acessam o sistema
    /// com a definição de um período de validade
    /// </summary>
    public class AccessTokenResponse : ResponseBase, IResponse
    {
        public string? Token { get; set; }
        public TimeOnly? TimedAt { get; set; }
        public DateOnly? ExpiringAt { get; set; }
    }
}
