namespace SchoolPro.Infra.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
