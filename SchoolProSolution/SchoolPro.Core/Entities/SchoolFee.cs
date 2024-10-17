namespace SchoolPro.Core.Entities
{
    public class SchoolFee : EntityBase
    {
        public decimal Value { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string StatusFee { get; set; } = null!;

        //Navigation Property
        public Guid? SchoolEnrollmentId { get; set; }
        public SchoolEnrollment? SchoolEnrollment { get; set; }
        public Guid? DocumentId { get; set; }
        public Document? Document { get; set; }
    }
}
