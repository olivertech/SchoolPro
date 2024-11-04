namespace SchoolPro.Core.Interfaces
{
    public class UserRepository : RepositoryAnonymousBase<User>, IUserRepository
    {
        public UserRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }

        public async Task<User?> ValidateLogin(string email, string password)
        {
            if (email == null || password == null)
                return null;

            return await _context!.Users!
                        .Include(ur => ur.Role!)
                        .Where(u => u.Email == email && u.Password == password)
                        .FirstOrDefaultAsync();
        }
    }
}
