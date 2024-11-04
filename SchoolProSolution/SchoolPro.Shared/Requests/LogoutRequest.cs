namespace SchoolPro.Shared.Requests
{
    public class LogoutRequest
    {
        public Guid? UserId { get; set; }
        public Guid? AccessTokenId { get; set; }
    }
}
