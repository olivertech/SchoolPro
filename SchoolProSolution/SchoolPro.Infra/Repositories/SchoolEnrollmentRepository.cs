namespace SchoolPro.Infra.Repositories
{
    public class SchoolEnrollmentRepository : RepositoryBase<SchoolEnrollment>, ISchoolEnrollmentRepository
    {
        public SchoolEnrollmentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
