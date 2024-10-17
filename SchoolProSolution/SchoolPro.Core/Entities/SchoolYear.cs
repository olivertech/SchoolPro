namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados do ano letivo
    /// </summary>
    public class SchoolYear : EntityBase
    {
        public int Year { get; set; } = DateTime.Today.Year;
        public string? Description { get; set; }
        public decimal Budget { get; set; }
        public decimal Billing { get; set; }
    }
}
