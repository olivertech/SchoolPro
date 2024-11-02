namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Recursos associados a Roles (Papéis)
    /// </summary>
    public class FeatureRoleRequest : RequestBase, IRequest
    {
        public Guid? FeatureId { get; set; }
        public Guid? RoleId { get; set; }
    }
}
