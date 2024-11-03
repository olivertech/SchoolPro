namespace SchoolPro.Infra.Repositories
{
    public class FeatureRepository : RepositoryAuthorizedBase<Feature>, IFeatureRepository
    {
        public FeatureRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
