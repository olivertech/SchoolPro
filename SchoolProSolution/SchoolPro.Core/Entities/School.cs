using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Classe que armazena os dados da
    /// escola
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
