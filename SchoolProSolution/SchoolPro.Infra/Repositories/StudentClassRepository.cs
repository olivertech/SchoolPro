namespace SchoolPro.Infra.Repositories
{
    public class StudentClassRepository : RepositoryBase<StudentClass>, IStudentClassRepository
    {
        public StudentClassRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
