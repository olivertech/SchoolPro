namespace SchoolPro.Infra.Repositories
{
    public class SchoolRepository : RepositoryBase<School>, ISchoolRepository
    {
        public SchoolRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
