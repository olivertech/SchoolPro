using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados de uma escola
    /// </summary>
    public class School : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        //Navigation Property
        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }
        public IList<Document>? Documents { get; set; }
    }
}
