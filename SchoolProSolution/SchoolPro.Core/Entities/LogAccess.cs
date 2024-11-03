namespace SchoolPro.Core.Entities
{
    public class LogAccess : AnonymousBase
    {
        public Guid UserId { get; set; }
        public TimeOnly? TimedAt { get; set; }

        //Navigation Property
        public User? User { get; set; }
    }
}
