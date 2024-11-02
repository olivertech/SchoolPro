namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response do relacionamento entre Usuário e Roles (Papéis)
    /// </summary>
    public class UserRoleResponse : ResponseBase, IResponse
    {
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }
    }
}
