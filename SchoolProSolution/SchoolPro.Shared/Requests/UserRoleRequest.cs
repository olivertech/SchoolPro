namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request do relacionamento entre Usuário e Roles (Papéis)
    /// </summary>
    public class UserRoleRequest : RequestBase, IRequest
    {
        [JsonPropertyName("user_id")]
        [JsonProperty(PropertyName = "user_id")]
        public Guid? UserId { get; set; }

        [JsonPropertyName("role_id")]
        [JsonProperty(PropertyName = "role_id")]
        public Guid? RoleId { get; set; }
    }
}
