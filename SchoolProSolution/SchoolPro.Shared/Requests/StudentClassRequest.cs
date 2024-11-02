namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Classe de Estudante
    /// </summary>
    public class StudentClassRequest : RequestBase, IRequest
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
        public int Capacity { get; set; } = 0;

        public Guid? RoomId { get; set; }
        public RoomRequest? Room { get; set; }

        //One-To-many
        public IList<StudentRequest>? Students { get; set; }
    }
}
