namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Usuário do Sistema
    /// </summary>
    public class UserRequest : RequestBase, IRequest
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

        [JsonPropertyName("email")]
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; } = null;

        [JsonPropertyName("password")]
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; } = null;

        [JsonPropertyName("picture_path")]
        [JsonProperty(PropertyName = "picture_path")]
        public string? PicturePath { get; set; } = null;

        [JsonPropertyName("is_active")]
        [JsonProperty(PropertyName = "is_active")]
        public bool IsActive { get; set; } = true;

        [JsonPropertyName("client_id")]
        [JsonProperty(PropertyName = "client_id")]
        public Guid ClientId { get; set; }
    }
}
