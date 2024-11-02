namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Escola
    /// </summary>
    public class SchoolRequest : RequestBase, IRequest
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

        public string CNPJ { get; set; } = null!;
        public string? StateRegistration { get; set; }
        public string? CountyRegistration { get; set; }
        public bool IsBranch { get; set; } = false;

        /// <summary>
        /// Chave única que identifica uma escola
        /// </summary>
        public Guid SchoolKey { get; set; } = Guid.NewGuid();

        //Navigation Property
        public Guid? ContactId { get; set; }
        public ContactRequest? Contact { get; set; }
        public Guid? ClientId { get; set; }
        public ClientRequest? Client{ get; set; }
        public IList<DocumentRequest>? Documents { get; set; }
    }
}
