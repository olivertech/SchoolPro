namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Professor
    /// </summary>
    public class TeacherRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; }
        public Guid? ContactId { get; set; }
    }
}
