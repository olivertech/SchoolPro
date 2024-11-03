namespace SchoolPro.Core.Interfaces
{
    public interface IUserRepository : IRepositoryAnonymousBase<User>
    {
        Task<User?> ValidateLogin(string email, string password);
    }
}
