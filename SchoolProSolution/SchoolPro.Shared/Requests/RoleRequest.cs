using SchoolPro.Core.Entities;

namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Papéis
    /// </summary>
    public class RoleRequest : RequestBase, IRequest
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
        public IList<UserRole>? UserRoles { get; set; }
        public IList<FeatureRole>? FeaturesRole { get; set; }
    }
}
