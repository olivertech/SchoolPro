using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    public class Teacher : EntityBase
    {
        public string Name { get; set; } = null!;
        public DateOnly? Birthdate { get; set; }
        public string Gender { get; set; } = null!;
    }
}
