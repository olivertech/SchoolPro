namespace SchoolPro.Infra.Repositories
{
    public class DocumentTypeRepository : RepositoryAuthorizedBase<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
