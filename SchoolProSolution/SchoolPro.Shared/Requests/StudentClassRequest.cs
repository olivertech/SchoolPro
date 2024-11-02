namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Classe de Estudante
    /// </summary>
    public class StudentClassRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public Guid? RoomId { get; set; }
    }
}
