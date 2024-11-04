namespace SchoolPro.Infra.Repositories
{
    public class SchoolRepository : RepositoryAnonymousBase<School>, ISchoolRepository
    {
        public SchoolRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }

        //public School GetUserSchool(Guid userId)
    }
}
