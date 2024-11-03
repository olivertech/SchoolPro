namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Log de Acesso
    /// </summary>
    public class LogAccessRequest : RequestBase, IRequest
    {
        public Guid? UserId { get; set; }
        public TimeOnly? TimedAt { get; set; }
    }
}
