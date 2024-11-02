namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Sala
    /// </summary>
    public class RoomRequest : RequestBase, IRequest
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

        public int Capacity { get; set; }

        //Navigation Property
        public Guid? SchoolId { get; set; }
        public SchoolRequest? School { get; set; }
    }
}
