namespace SchoolPro.Infra.Repositories
{
    public class LogAccessRepository : RepositoryAnonymousBase<LogAccess>, ILogAccessRepository
    {
        public LogAccessRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
