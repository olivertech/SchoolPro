namespace SchoolPro.Infra.Repositories
{
    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
