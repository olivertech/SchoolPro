namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados de uma sala de aula
    /// </summary>
    public class Room : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Capacity { get; set; }

        //Navigation Property
        public Guid? SchoolId { get; set; }
        public School? School { get; set; }
    }
}
