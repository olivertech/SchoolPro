
namespace SchoolPro.Api.ManagementArea.Auth
{
    internal class SecurityTokenDescriptor
    {
        public object Subject { get; set; }
        public DateTime Expires { get; set; }
        public object Issuer { get; set; }
        public object Audience { get; set; }
        public object SigningCredentials { get; set; }
    }
}