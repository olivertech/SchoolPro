namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request do relacionamento entre Usuário e Roles (Papéis)
    /// </summary>
    public class UserRoleRequest : RequestBase, IRequest
    {
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }
    }
}
