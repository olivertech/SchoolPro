namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Ebtidade que armazena os dados de uma matéria
    /// </summary>
    public class SchoolSubject : AuthorizedBase
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        // Many-to-many relation
        public IList<TeacherSchoolSubject>? TeacherSchoolSubjects { get; set; }
    }
}
