using System.Xml.Linq;

namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Cliente
    /// </summary>
    public class ClientRequest : RequestBase, IRequest
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

        public string? ResponsableName { get; set; }
        public string? ResponsableEmail { get; set; }
        public string? ResponsableCellPhone1 { get; set; }
        public string? ResponsableCellPhone2 { get; set; }

        /// <summary>
        /// Chave única que identifica um cliente
        /// </summary>
        public Guid ClientKey { get; set; } = Guid.NewGuid();

        //Navigation Properties
        public IList<SchoolRequest>? Schools { get; set; }
    }
}
