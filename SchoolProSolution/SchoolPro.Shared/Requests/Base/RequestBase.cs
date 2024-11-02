namespace SchoolPro.Shared.ManagementArea.Requests.Base
{
    public abstract class RequestBase
    {
        public Guid? Id { get; set; }
        public Guid? ClientSchoolKey { get; set; }
    }
}
