namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Features (Recursos do sistema)
    /// </summary>
    public class FeatureRequest : RequestBase, IRequest
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

        //Items used for visualization
        public string? MenuName { get; set; }
        public string? MenuTip { get; set; }
        public string? MenuEndPoint { get; set; }
        public string? MenuIcon { get; set; }
        public IList<FeatureRoleRequest>? FeaturesRole { get; set; }
    }
}
