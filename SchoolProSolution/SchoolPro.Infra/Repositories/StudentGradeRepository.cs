namespace SchoolPro.Infra.Repositories
{
    public class StudentGradeRepository : RepositoryBase<StudentGrade>, IStudentGradeRepository
    {
        public StudentGradeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
