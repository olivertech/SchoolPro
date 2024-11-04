namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados de uma escola
    /// </summary>
    public class School : AnonymousBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string CNPJ { get; set; } = null!;
        public string? StateRegistration { get; set; }
        public string? CountyRegistration { get; set; }
        public bool IsBranch { get; set; } = false;

        /// <summary>
        /// Chave única que identifica uma escola
        /// </summary>
        public string SchoolSecretKey { get; set; } = null!;

        //Navigation Property
        public Guid? ContactId { get; set; }
        public Contact? Contact { get; set; }
        public Guid? ClientId { get; set; }
        public Client? Client{ get; set; }
        public IList<Document>? Documents { get; set; }
    }
}
