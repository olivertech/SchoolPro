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

        public async Task DeleteLoggedUserAccessToken(Guid userId)
        {
            var user = await _context!.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if(user != null)
            {
                var accessToken = await _context!.AccessTokens.Where(x => x.Id == user.AccessTokenId).FirstOrDefaultAsync();

                if(accessToken != null)
                {
                    _context.AccessTokens.Remove(accessToken);
                    _context!.SaveChanges();
                }
            }
        }
    }
}
