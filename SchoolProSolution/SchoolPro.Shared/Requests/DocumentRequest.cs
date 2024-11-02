namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Documento
    /// </summary>
    public class DocumentRequest : RequestBase, IRequest
    {
        public string? Title { get; set; } = null!;

        [JsonPropertyName("description")]
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        public string? FilePath { get; set; }

        // Polymorphic relationship properties
        public Guid? StudentId { get; set; }
        public StudentRequest? Student { get; set; }

        public Guid? TeacherId { get; set; }
        public TeacherRequest? Teacher { get; set; }

        public Guid? ParentId { get; set; }
        public ParentRequest? Parent { get; set; }

        public Guid? SchoolId { get; set; }
        public SchoolRequest? School { get; set; }

        public Guid? DocumentTypeId { get; set; }
        public DocumentTypeRequest? DocumentType { get; set; }
    }
}
