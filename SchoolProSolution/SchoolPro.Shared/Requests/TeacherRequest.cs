namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Professor
    /// </summary>
    public class TeacherRequest : RequestBase, IRequest
    {
        [JsonPropertyName("user_name")]
        [JsonProperty(PropertyName = "user_name")]
        public string? Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value is not null)
                    _name = value.ToString().ToUpper();
            }
        }

        private string? _name;

        [JsonPropertyName("description")]
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        public DateOnly? Birthdate { get; set; }
        public string Gender { get; set; } = null!;

        //Navigation Property
        public Guid? ContactId { get; set; }
        public ContactRequest? Contact { get; set; }

        // Many-to-many relation
        public IList<TeacherSchoolSubjectRequest>? TeacherSchoolSubjects { get; set; }
        public IList<DocumentRequest>? Documents { get; set; }
    }
}
