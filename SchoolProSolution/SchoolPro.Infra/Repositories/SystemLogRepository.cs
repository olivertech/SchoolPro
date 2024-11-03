namespace SchoolPro.Infra.Repositories
{
    public class SystemLogRepository : RepositoryAnonymousBase<SystemLog>, ISystemLogRepository
    {
        public SystemLogRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
