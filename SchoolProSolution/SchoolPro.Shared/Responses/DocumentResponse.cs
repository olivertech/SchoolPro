namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Documento
    /// </summary>
    public class DocumentResponse : ResponseBase, IResponse
    {
        public string? Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? FilePath { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? TeacherId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? SchoolId { get; set; }
        public Guid? DocumentTypeId { get; set; }
    }
}
