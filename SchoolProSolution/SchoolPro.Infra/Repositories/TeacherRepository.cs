namespace SchoolPro.Infra.Repositories
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
