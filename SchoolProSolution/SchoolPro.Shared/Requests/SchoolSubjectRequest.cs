namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Matéria Escolar
    /// </summary>
    public class SchoolSubjectRequest : RequestBase, IRequest
    {
        public string Title { get; set; } = null!;

        [JsonPropertyName("description")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; } = null!;

        // Many-to-many relation
        public IList<TeacherSchoolSubjectRequest>? TeacherSchoolSubjects { get; set; }
    }
}
