namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Parente
    /// </summary>
    public class ParentResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; } = null!;
        public string? Kinship { get; set; } = null!;
        public Guid? ContactId { get; set; }
    }
}
