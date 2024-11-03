namespace SchoolPro.Infra.Repositories
{
    public class StudentParentRepository : RepositoryAuthorizedBase<StudentParent>, IStudentParentRepository
    {
        public StudentParentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
