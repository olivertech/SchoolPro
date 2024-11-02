namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Usuário do Sistema
    /// </summary>
    public class UserRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PicturePath { get; set; }
        public bool IsActive { get; set; }
        public Guid ClientId { get; set; }
    }
}
