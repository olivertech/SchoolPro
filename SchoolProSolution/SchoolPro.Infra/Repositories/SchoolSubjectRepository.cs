namespace SchoolPro.Infra.Repositories
{
    public class SchoolSubjectRepository : RepositoryBase<SchoolSubject>, ISchoolSubjectRepository
    {
        public SchoolSubjectRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
