namespace SchoolPro.Infra.Repositories
{
    public class FeeTypeRepository : RepositoryAuthorizedBase<FeeType>, IFeeTypeRepository
    {
        public FeeTypeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
