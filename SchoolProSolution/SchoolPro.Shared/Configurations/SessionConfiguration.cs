namespace SchoolPro.Shared.Configurations
{
    /// <summary>
    /// Estrutura que armazena dados de sessão de um usuário logado
    /// </summary>
    public class SessionConfiguration
    {
        public Guid LoggedUserId { get; set; }
        public Guid LoggedSchoolId { get; set; }
        public Guid LoggedClientId { get; set; }
        public string? ClientSchoolKey { get; set; }
        public DateTime SessionCreatedAt { get; set; }
        public DateTime SessionLastAt { get; set; }
        public AccessToken? AccessToken { get; set; }
    }
}
