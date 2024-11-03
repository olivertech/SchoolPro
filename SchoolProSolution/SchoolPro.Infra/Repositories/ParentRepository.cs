namespace SchoolPro.Infra.Repositories
{
    public class ParentRepository : RepositoryAuthorizedBase<Parent>, IParentRepository
    {
        public ParentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
