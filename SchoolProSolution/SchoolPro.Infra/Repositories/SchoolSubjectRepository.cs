namespace SchoolPro.Infra.Repositories
{
    public class SchoolSubjectRepository : RepositoryAuthorizedBase<SchoolSubject>, ISchoolSubjectRepository
    {
        public SchoolSubjectRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
