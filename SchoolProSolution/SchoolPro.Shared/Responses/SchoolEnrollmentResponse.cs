namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Matrícula Escolar
    /// </summary>
    public class SchoolEnrollmentResponse : ResponseBase, IResponse
    {
        public string? Enrollment { get; set; }
        public bool Approved { get; set; }
        public string? FinalGrade { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? SchoolYearId { get; set; }
        public Guid? DocumentId { get; set; }
    }
}
