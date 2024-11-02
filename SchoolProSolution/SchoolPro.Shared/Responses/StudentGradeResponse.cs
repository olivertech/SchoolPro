namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Nota de Estudante
    /// </summary>
    public class StudentGradeResponse : ResponseBase, IResponse
    {
        public Guid? StudentId { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public decimal Grade { get; set; }
        public DateOnly DateGrade { get; set; }
        public Guid? StudentClassId { get; set; }
    }
}
