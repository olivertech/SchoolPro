namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Recursos associados a Roles (Papéis)
    /// </summary>
    public class FeatureRoleResponse : ResponseBase, IResponse
    {
        public Guid? FeatureId { get; set; }
        public Guid? RoleId { get; set; }
    }
}
