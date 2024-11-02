namespace SchoolPro.Infra.Repositories
{
    public class FeatureRepository : RepositoryBase<Feature>, IFeatureRepository
    {
        public FeatureRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
