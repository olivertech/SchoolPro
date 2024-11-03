namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena as notas do estudante
    /// </summary>
    public class StudentGrade : AuthorizedBase
    {
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubject? SchoolSubject { get; set; }
        public decimal Grade { get; set; }
        public DateOnly DateGrade { get; set; } = new DateOnly();

        //Navigation Property
        public Guid? StudentClassId { get; set; }
        public StudentClass? StudentClass { get; set; }
    }
}
