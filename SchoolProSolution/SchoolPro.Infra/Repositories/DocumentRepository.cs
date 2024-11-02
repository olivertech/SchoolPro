namespace SchoolPro.Infra.Repositories
{
    public class DocumentRepository : RepositoryBase<Document>, IDocumentRepository
    {
        public DocumentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
