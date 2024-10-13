using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    public class Student : EntityBase
    {
        public string Name { get; set; } = null!;
        public DateOnly? Birthdate { get; set; }
        public string Gender { get; set; } = null!;

        //Navigation Property
        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }

        //One-To-many
        public IList<Document>? Documents { get; set; }
        public IList<StudentParent>? StudentParents { get; set; }
    }
}
