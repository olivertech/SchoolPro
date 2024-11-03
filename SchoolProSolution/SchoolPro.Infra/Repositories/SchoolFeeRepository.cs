namespace SchoolPro.Infra.Repositories
{
    public class SchoolFeeRepository : RepositoryAuthorizedBase<SchoolFee>, ISchoolFeeRepository
    {
        public SchoolFeeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
