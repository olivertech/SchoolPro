namespace SchoolPro.Infra.Repositories
{
    public class TeacherSchoolSubjectRepository : RepositoryAuthorizedBase<TeacherSchoolSubject>, ITeacherSchoolSubjectRepository
    {
        public TeacherSchoolSubjectRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
