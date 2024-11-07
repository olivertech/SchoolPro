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

            //CONSIDERAR QUE AS SENHAS FUTURAMENTE SERÃO CRIPTOGRAFADAS E QUE 
            //PRECISARÁ SER FEITA ESSA OPERAÇÃO DE PEGAR A SENHA RECEBIDA, 
            //CRIPTOGRAFAR E COMPARAR COM A DO BANCO DE DADOS

            var user = await _context!.Users!
                        .Include(ur => ur.Role!)
                        .Where(u => u.Email == email && u.Password == password)
                        .FirstOrDefaultAsync();

            return user;
        }
    }
}
