namespace SchoolPro.Core.Interfaces
{
    public interface IAccessTokenRepository : IRepositoryAuthorizedBase<AccessToken>
    {
        Task<AccessToken?> GetToken(User user);
    }
}
