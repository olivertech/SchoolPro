namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Classe de Estudante
    /// </summary>
    public class StudentClassResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public Guid? RoomId { get; set; }
    }
}
