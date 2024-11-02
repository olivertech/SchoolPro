namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Nota de Estudante
    /// </summary>
    public class StudentGradeRequest : RequestBase, IRequest
    {
        public Guid? StudentId { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public decimal Grade { get; set; }
        public DateOnly DateGrade { get; set; }
        public Guid? StudentClassId { get; set; }
    }
}
