namespace SchoolPro.Infra.Repositories
{
    public class SchoolYearRepository : RepositoryBase<SchoolYear>, ISchoolYearRepository
    {
        public SchoolYearRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
