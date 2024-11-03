namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena todas as ações realizadas
    /// pelo usuário no sistema, e em caso de envio ou
    /// recebimento de json, será armazenado de forma
    /// otimizada esse json, pra rastreabilidade do
    /// que foi enviado ou recebido
    /// </summary>
    public class SystemLog : AnonymousBase
    {
        public string? Action { get; set; }
        public string? Json { get; set; }
        public TimeOnly? TimedAt { get; set; }

        //Navigation Property
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
