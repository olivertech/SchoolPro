namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Matrícula Escolar
    /// </summary>
    public class SchoolEnrollmentRequest : RequestBase, IRequest
    {
        public string Enrollment { get; set; } = null!;
        public bool Approved { get; set; }
        public string? FinalGrade { get; set; }

        //Navigation Property
        public Guid? StudentId { get; set; }
        public StudentRequest? Student { get; set; }

        public Guid? SchoolYearId { get; set; }
        public SchoolYearRequest? SchoolYear { get; set; }

        public Guid? DocumentId { get; set; }
        public DocumentRequest? Document { get; set; }
    }
}
