namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Classe que guarda os tokens de autorização 
    /// dos usuários que acessam o sistema
    /// com a definição de um período de validade
    /// </summary>
    public class AccessToken : EntityBase
    {
        public string? Token { get; set; }
        public TimeOnly? TimedAt { get; set; }
        public DateOnly? ExpiringAt { get; set; }
    }
}
