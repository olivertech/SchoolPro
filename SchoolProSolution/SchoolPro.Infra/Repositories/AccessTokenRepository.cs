namespace SchoolPro.Infra.Repositories
{
    public class AccessTokenRepository : RepositoryAuthorizedBase<AccessToken>, IAccessTokenRepository
    {
        public AccessTokenRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }

        public async Task<AccessToken?> GetToken(User user)
        {
            if (user == null)
                return null;

            return await _context!.AccessTokens
                .Where(x => x.Id == user.AccessTokenId)
                .FirstOrDefaultAsync();
        }
    }
}
