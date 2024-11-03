namespace SchoolPro.Infra.Repositories
{
    public class StudentRepository : RepositoryAuthorizedBase<Student>, IStudentRepository
    {
        public StudentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
