namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena as matrículas escolares
    /// </summary>
    public class SchoolEnrollment : AuthorizedBase
    {
        public string Enrollment { get; set; } = null!;
        public bool Approved { get; set; }
        public string? FinalGrade { get; set; }

        //Navigation Property
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? SchoolYearId { get; set; }
        public SchoolYear? SchoolYear { get; set; }
    }
}
