namespace SchoolPro.Infra.Repositories
{
    public class ContactRepository : RepositoryAuthorizedBase<Contact>, IContactRepository
    {
        public ContactRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
