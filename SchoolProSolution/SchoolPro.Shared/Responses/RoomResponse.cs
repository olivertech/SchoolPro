namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Sala
    /// </summary>
    public class RoomResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public Guid? SchoolId { get; set; }
    }
}
