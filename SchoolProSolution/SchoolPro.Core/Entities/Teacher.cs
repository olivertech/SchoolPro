namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados dos professores
    /// </summary>
    public class Teacher : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string Gender { get; set; } = null!;

        //Navigation Property
        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }

        // Many-to-many relation
        public IList<TeacherSchoolSubject>? TeacherSchoolSubjects { get; set; }
        public IList<Document>? Documents { get; set; }
    }
}
