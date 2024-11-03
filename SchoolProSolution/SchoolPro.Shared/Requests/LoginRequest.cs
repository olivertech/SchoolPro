namespace SchoolPro.Shared.Requests
{
    public class LoginRequest : IRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
