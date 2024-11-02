namespace SchoolPro.Infra.Repositories
{
    public class SchoolFeeRepository : RepositoryBase<SchoolFee>, ISchoolFeeRepository
    {
        public SchoolFeeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
