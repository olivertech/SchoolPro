namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Cliente
    /// </summary>
    public class ClientRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ResponsableName { get; set; }
        public string? ResponsableEmail { get; set; }
        public string? ResponsableCellPhone1 { get; set; }
        public string? ResponsableCellPhone2 { get; set; }
    }
}
