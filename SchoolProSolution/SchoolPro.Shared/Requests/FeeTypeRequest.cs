namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Tipo de Taxa
    /// </summary>
    public class FeeTypeRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
