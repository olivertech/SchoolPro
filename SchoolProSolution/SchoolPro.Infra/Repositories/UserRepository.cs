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

            //Recupero o usuário com a senha criptografada no banco
            var user = await _context!.Users!
                        .Include(ur => ur.Role!)
                        .Where(u => u.Email == email)
                        .FirstOrDefaultAsync();

            //Verifico se a senha fornecida corresponde ao hash armazenado
            var result = BCrypt.Net.BCrypt.Verify(password, user!.Password);

            return result ? user : null;
        }
    }
}
