namespace SchoolPro.Core.Entities
{
    public class SchoolEnrollment : EntityBase
    {
        public string Enrollment { get; set; } = null!;
        public bool Approved { get; set; }

        //Navigation Property
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? SchoolYearId { get; set; }
        public SchoolYear? SchoolYear { get; set; }
    }
}
