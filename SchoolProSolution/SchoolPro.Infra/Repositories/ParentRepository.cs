namespace SchoolPro.Infra.Repositories
{
    public class ParentRepository : RepositoryBase<Parent>, IParentRepository
    {
        public ParentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
