namespace SchoolPro.Infra.Repositories
{
    public class StudentGradeRepository : RepositoryAuthorizedBase<StudentGrade>, IStudentGradeRepository
    {
        public StudentGradeRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
