namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazendo os tipos de taxas cobradas
    /// </summary>
    public class FeeType : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
