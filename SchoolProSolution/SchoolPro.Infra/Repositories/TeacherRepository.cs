namespace SchoolPro.Infra.Repositories
{
    public class TeacherRepository : RepositoryAuthorizedBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
