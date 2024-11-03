namespace SchoolPro.Infra.Repositories
{
    public class ClientRepository : RepositoryAnonymousBase<Client>, IClientRepository
    {
        public ClientRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
