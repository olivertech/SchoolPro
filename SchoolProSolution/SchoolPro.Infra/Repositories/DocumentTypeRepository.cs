namespace SchoolPro.Infra.Repositories
{
    public class DocumentTypeRepository : RepositoryBase<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
