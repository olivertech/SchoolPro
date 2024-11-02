namespace SchoolPro.Infra.Repositories
{
    public class TeacherSchoolSubjectRepository : RepositoryBase<TeacherSchoolSubject>, ITeacherSchoolSubjectRepository
    {
        public TeacherSchoolSubjectRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
