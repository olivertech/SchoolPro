namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response do relacionamento de Estudando com Parentes
    /// </summary>
    public class StudentParentResponse : ResponseBase, IResponse
    {
        public Guid? StudentId { get; set; }
        public Guid? ParentId { get; set; }
    }
}
