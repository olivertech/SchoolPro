namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Sala
    /// </summary>
    public class RoomRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public Guid? SchoolId { get; set; }
    }
}
