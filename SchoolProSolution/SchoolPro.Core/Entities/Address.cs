namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena todos os endereços associados
    /// a alunos, responsáveis, escolas e professores
    /// </summary>
    public class Address : EntityBase
    {
        public string? StreetAddress { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string? Neighborhood { get; set; } = null!;
        public string? City { get; set; } = null!;
        public string? State { get; set; } = null!;
        public string? PostalCode { get; set; }        
    }
}
