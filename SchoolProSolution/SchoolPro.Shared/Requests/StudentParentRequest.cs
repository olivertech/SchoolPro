namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request do relacionamento de Estudando com Parentes
    /// </summary>
    public class StudentParentRequest : RequestBase, IRequest
    {
        public Guid? StudentId { get; set; }
        public StudentRequest? Student { get; set; }

        public Guid? ParentId { get; set; }
        public ParentRequest? Parent { get; set; }
    }
}
