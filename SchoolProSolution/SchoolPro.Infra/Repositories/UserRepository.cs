namespace SchoolPro.Core.Interfaces
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
