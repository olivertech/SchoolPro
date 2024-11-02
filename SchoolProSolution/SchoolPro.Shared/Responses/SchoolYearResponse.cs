namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Ano Letivo
    /// </summary>
    public class SchoolYearResponse : ResponseBase, IResponse
    {
        public int Year { get; set; }
        public string? Description { get; set; }
        public decimal Budget { get; set; }
        public decimal Billing { get; set; }
    }
}
