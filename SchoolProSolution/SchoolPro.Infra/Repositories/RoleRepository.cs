namespace SchoolPro.Infra.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
