namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados da classe
    /// onde estão agrupados os estudantes
    /// </summary>
    public class StudentClass : AuthorizedBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Capacity { get; set; } = 0;

        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }

        //One-To-many
        public IList<Student>? Students { get; set; }
    }
}
