namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Pagamento
    /// </summary>
    public class SchoolFeeRequest : ResponseBase, IResponse
    {
        public decimal Value { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string? StatusFee { get; set; }
        public Guid? SchoolEnrollmentId { get; set; }
        public Guid? DocumentId { get; set; }
        public Guid? FeeTypeId { get; set; }
    }
}
