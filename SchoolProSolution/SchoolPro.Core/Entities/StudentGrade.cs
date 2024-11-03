namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena as notas do estudante
    /// </summary>
    public class StudentGrade : AuthorizedBase
    {
        public string? Description { get; set; }
        public decimal MinimalGrade { get; set; }
        public decimal Grade { get; set; }
        public DateOnly DateGrade { get; set; } = new DateOnly();

        //Navigation Property
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubject? SchoolSubject { get; set; }
        public Guid? StudentClassId { get; set; }
        public StudentClass? StudentClass { get; set; }
        public Guid? SchoolEnrollmentId { get; set; }
        public SchoolEnrollment? SchoolEnrollment { get; set; }
    }
}
