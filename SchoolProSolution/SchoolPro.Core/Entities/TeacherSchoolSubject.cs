namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena o relacionamento dos professores com as matérias que ele leciona
    /// </summary>
    public class TeacherSchoolSubject : AuthorizedBase
    {
        //Navigation Property
        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubject? SchoolSubject { get; set; }
    }
}
