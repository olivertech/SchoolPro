namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Papéis
    /// </summary>
    public class RoleResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
