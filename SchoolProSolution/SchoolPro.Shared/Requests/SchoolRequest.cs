namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Escola
    /// </summary>
    public class SchoolRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CNPJ { get; set; }
        public string? StateRegistration { get; set; }
        public string? CountyRegistration { get; set; }
        public bool IsBranch { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? ClientId { get; set; }
    }
}
