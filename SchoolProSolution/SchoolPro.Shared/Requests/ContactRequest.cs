namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Contato
    /// </summary>
    public class ContactRequest : RequestBase, IRequest
    {
        public string? Telephone { get; set; }
        public string? CellPhone { get; set; }
        public string? Email { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public string? Github { get; set; }
        public string? StreetAddress { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string? Neighborhood { get; set; } = null!;
        public string? City { get; set; } = null!;
        public string? State { get; set; } = null!;
        public string? PostalCode { get; set; }        
    }
}
