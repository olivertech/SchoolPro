namespace SchoolPro.Infra.Repositories
{
    public class FeeTypeRepository : RepositoryBase<FeeType>, IFeeTypeRepository
    {
        public FeeTypeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
