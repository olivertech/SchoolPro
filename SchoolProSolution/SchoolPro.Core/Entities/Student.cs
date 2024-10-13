using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    public class Student : EntityBase
    {
        public string Name { get; set; } = null!;
        public DateOnly? Birthdate { get; set; }
        public string Gender { get; set; } = null!;

        //Navigation Property
        public Address? Address { get; set; }
    }
}
