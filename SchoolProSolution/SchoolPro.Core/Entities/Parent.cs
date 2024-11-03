namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados dos responsáveis
    /// pelo aluno, e o seu grau de parentesco
    /// </summary>
    public class Parent : AuthorizedBase
    {
        public string? Name { get; set; } = null!;
        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; } = null!;
        public string? Kinship { get; set; } = null!;

        //Navigation Property
        public Guid? ContactId { get; set; }
        public Contact? Contact { get; set; }
        public IList<Document>? Documents { get; set; }
        public IList<StudentParent>? StudentParents { get; set; }
    }
}
