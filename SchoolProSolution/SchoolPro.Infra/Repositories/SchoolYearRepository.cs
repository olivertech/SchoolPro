namespace SchoolPro.Infra.Repositories
{
    public class SchoolYearRepository : RepositoryAuthorizedBase<SchoolYear>, ISchoolYearRepository
    {
        public SchoolYearRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
