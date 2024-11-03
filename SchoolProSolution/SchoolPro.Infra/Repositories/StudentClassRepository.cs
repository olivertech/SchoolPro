namespace SchoolPro.Infra.Repositories
{
    public class StudentClassRepository : RepositoryAuthorizedBase<StudentClass>, IStudentClassRepository
    {
        public StudentClassRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
