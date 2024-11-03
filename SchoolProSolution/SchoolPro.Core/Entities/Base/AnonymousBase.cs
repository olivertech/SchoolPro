namespace SchoolPro.Core.Entities.Base
{
    public class AnonymousBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; } = true;
        public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly? UpdatedAt { get; set; }
        public DateOnly? DeletedAt { get; set; }
    }
}
