namespace SchoolPro.Shared.ManagementArea.Requests.Base
{
    public abstract class RequestBase
    {
        [JsonPropertyName("id")]
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("client_school_key")]
        [JsonProperty(PropertyName = "client_school_key")]
        public Guid ClientSchoolKey { get; set; } = Guid.NewGuid();
    }
}
