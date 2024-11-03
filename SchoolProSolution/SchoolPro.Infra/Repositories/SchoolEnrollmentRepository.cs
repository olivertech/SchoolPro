namespace SchoolPro.Infra.Repositories
{
    public class SchoolEnrollmentRepository : RepositoryAuthorizedBase<SchoolEnrollment>, ISchoolEnrollmentRepository
    {
        public SchoolEnrollmentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
