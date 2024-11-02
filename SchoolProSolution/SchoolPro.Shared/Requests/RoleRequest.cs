namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Papéis
    /// </summary>
    public class RoleRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
