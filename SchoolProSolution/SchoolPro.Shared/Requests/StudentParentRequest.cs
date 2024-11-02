namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request do relacionamento de Estudando com Parentes
    /// </summary>
    public class StudentParentRequest : RequestBase, IRequest
    {
        public Guid? StudentId { get; set; }
        public Guid? ParentId { get; set; }
    }
}
