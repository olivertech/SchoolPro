namespace SchoolPro.Infra.Repositories
{
    public class DocumentRepository : RepositoryAuthorizedBase<Document>, IDocumentRepository
    {
        public DocumentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
