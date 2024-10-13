using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    public class SchoolSubject : EntityBase
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        // Many-to-many relation
        public IList<TeacherSchoolSubject>? TeacherSchoolSubjects { get; set; }
    }
}
