using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    public class Teacher : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string Gender { get; set; } = null!;

        // Many-to-many relation
        public IList<TeacherSchoolSubject>? TeacherSchoolSubjects { get; set; }
        public IList<Document>? Documents { get; set; }
    }
}
