namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Parente
    /// </summary>
    public class ParentRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; } = null!;
        public string? Kinship { get; set; } = null!;
        public Guid? ContactId { get; set; }
    }
}
