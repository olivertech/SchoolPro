namespace SchoolPro.Infra.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
