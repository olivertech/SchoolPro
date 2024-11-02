namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Parente
    /// </summary>
    public class ParentRequest : RequestBase, IRequest
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

        public DateOnly? Birthdate { get; set; }
        public string? Gender { get; set; } = null!;
        public string? Kinship { get; set; } = null!;

        //Navigation Property
        public Guid? ContactId { get; set; }
        public ContactRequest? Contact { get; set; }
        public IList<DocumentRequest>? Documents { get; set; }
        public IList<StudentParentRequest>? StudentParents { get; set; }
    }
}
