namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena o relacionamento do aluno com seus parentes
    /// </summary>
    public class StudentParent : EntityBase
    {
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? ParentId { get; set; }
        public Parent? Parent { get; set; }
    }
}
