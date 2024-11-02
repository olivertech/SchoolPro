namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Nota de Estudante
    /// </summary>
    public class StudentGradeRequest : RequestBase, IRequest
    {
        public Guid? StudentId { get; set; }
        public StudentRequest? Student { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubjectRequest? SchoolSubject { get; set; }
        public decimal Grade { get; set; }
        public DateOnly DateGrade { get; set; } = new DateOnly();

        //Navigation Property
        public Guid? StudentClassId { get; set; }
        public StudentClassRequest? StudentClass { get; set; }
    }
}
