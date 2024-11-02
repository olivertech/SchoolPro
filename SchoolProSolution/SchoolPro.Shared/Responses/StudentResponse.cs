namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Estudante
    /// </summary>
    public class StudentResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? StudentClassId { get; set; }
    }
}
