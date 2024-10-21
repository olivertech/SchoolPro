namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena todos os documentos associados
    /// a alunos, parentes, escolas e professores
    /// </summary>
    public class Document : EntityBase
    {
        public string? Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? FilePath { get; set; }

        // Polymorphic relationship properties
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public Guid? ParentId { get; set; }
        public Parent? Parent { get; set; }

        public Guid? SchoolId { get; set; }
        public School? School { get; set; }

        public Guid? DocumentTypeId { get; set; }
        public DocumentType? DocumentType { get; set; }
    }
}
