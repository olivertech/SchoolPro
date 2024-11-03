namespace SchoolPro.Infra.Repositories
{
    public class RoleRepository : RepositoryAuthorizedBase<Role>, IRoleRepository
    {
        public RoleRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
