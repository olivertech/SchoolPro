namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Pagamento
    /// </summary>
    public class SchoolFeeRequest : RequestBase, IRequest
    {
        public decimal Value { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string StatusFee { get; set; } = null!;

        //Navigation Properties
        public Guid? SchoolEnrollmentId { get; set; }
        public SchoolEnrollmentRequest? SchoolEnrollment { get; set; }
        public Guid? DocumentId { get; set; }
        public DocumentRequest? Document { get; set; }
        public Guid? FeeTypeId { get; set; }
        public FeeTypeRequest? FeeType { get; set; }
    }
}
