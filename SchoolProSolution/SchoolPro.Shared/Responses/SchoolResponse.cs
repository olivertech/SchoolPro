namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Escola
    /// </summary>
    public class SchoolResponse : ResponseBase, IResponse
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
