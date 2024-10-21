namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena todos os dados de um aluno
    /// </summary>
    public class Student : EntityBase
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateOnly? Birthdate { get; set; }
        public string Gender { get; set; } = null!;

        //Navigation Property
        public Guid? ContactId { get; set; }
        public Contact? Contact { get; set; }

        public Guid? StudentClassId { get; set; }
        public StudentClass? StudentClass { get; set; }

        //One-To-many
        public IList<Document>? Documents { get; set; }
        public IList<StudentParent>? StudentParents { get; set; }
    }
}
