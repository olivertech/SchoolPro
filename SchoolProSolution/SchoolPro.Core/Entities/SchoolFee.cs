namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados de pagamentos em geral
    /// </summary>
    public class SchoolFee : EntityBase
    {
        public decimal Value { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string StatusFee { get; set; } = null!;

        //Navigation Properties
        public Guid? SchoolEnrollmentId { get; set; }
        public SchoolEnrollment? SchoolEnrollment { get; set; }
        public Guid? DocumentId { get; set; }
        public Document? Document { get; set; }
        public Guid? FeeTypeId { get; set; }
        public FeeType? FeeType { get; set; }
    }
}
