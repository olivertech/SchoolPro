namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade responsável por amarrar todas as referências
    /// que irão compor um calendário escolar, considerando:
    /// 
    /// - A sala onde será ministrada uma aula
    /// - O professor que vai dar aula naquela sala
    /// - O professor suplente que pode existir
    /// - A matéria que será ministrada naquela sala
    /// - A data do ano que será ministrada a aula
    /// - O horario que começa a aula
    /// - O horario que termina a aula
    /// 
    /// </summary>
    public class SchoolCalendar : EntityBase
    {
        public string? Description { get; set; }
        public DateOnly Date { get; set; } = new DateOnly();
        public TimeOnly TimeFrom { get; set; }
        public TimeOnly TimeTo { get; set; }

        //Navigation Property
        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubject? SchoolSubject { get; set; }
        public Guid? SchoolYearId { get; set; }
        public SchoolYear? SchoolYear { get; set; }
    }
}
