namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Matrícula Escolar
    /// </summary>
    public class SchoolEnrollmentRequest : RequestBase, IRequest
    {
        public string? Enrollment { get; set; }
        public bool Approved { get; set; }
        public string? FinalGrade { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? SchoolYearId { get; set; }
        public Guid? DocumentId { get; set; }
    }
}
