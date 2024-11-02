namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Cliente
    /// </summary>
    public class ClientResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ResponsableName { get; set; }
        public string? ResponsableEmail { get; set; }
        public string? ResponsableCellPhone1 { get; set; }
        public string? ResponsableCellPhone2 { get; set; }
    }
}
