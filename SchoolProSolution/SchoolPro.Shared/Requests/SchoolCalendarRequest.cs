namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Calendário Escolar
    /// </summary>
    public class SchoolCalendarRequest : RequestBase, IRequest
    {
        [JsonPropertyName("description")]
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        public DateOnly Date { get; set; } = new DateOnly();
        public TimeOnly TimeFrom { get; set; }
        public TimeOnly TimeTo { get; set; }

        //Navigation Property
        public Guid? RoomId { get; set; }
        public RoomRequest? Room { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubjectRequest? SchoolSubject { get; set; }
        public Guid? SchoolYearId { get; set; }
        public SchoolYearRequest? SchoolYear { get; set; }
    }
}
