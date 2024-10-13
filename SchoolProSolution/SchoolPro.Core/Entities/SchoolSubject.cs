using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Ebtidade que armazena os dados de uma matéria
    /// </summary>
    public class SchoolSubject : EntityBase
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        // Many-to-many relation
        public IList<TeacherSchoolSubject>? TeacherSchoolSubjects { get; set; }
    }
}
