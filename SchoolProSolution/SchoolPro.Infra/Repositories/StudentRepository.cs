namespace SchoolPro.Infra.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
