namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Calendário Escolar
    /// </summary>
    public class SchoolCalendarRequest : RequestBase, IRequest
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
