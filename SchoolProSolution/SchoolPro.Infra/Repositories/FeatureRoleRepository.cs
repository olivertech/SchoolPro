namespace SchoolPro.Infra.Repositories
{
    public class FeatureRoleRepository : RepositoryAuthorizedBase<FeatureRole>, IFeatureRoleRepository
    {
        public FeatureRoleRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
