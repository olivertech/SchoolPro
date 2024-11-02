namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Calendário Escolar
    /// </summary>
    public class SchoolCalendarResponse : ResponseBase, IResponse
    {
        public string? Description { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly TimeFrom { get; set; }
        public TimeOnly TimeTo { get; set; }
        public Guid? RoomId { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public Guid? SchoolYearId { get; set; }
    }
}
