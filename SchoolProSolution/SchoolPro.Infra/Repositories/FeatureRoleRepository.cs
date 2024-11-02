namespace SchoolPro.Infra.Repositories
{
    public class FeatureRoleRepository : RepositoryBase<FeatureRole>, IFeatureRoleRepository
    {
        public FeatureRoleRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
