namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Estudante
    /// </summary>
    public class StudentRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? StudentClassId { get; set; }
    }
}
