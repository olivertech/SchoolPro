using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Classe que armazena os dados dos responsáveis
    /// pelo aluno, e o seu grau de parentesco
    /// </summary>
    public class Parent : EntityBase
    {
        public string? Name { get; set; } = null!;
        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; } = null!;
        public string? Kinship { get; set; } = null!;
        
        //Navigation Property
        public Student? User { get; set; }
        public Address? Address { get; set; }
    }
}
