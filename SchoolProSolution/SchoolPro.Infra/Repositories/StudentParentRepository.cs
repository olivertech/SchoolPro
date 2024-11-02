namespace SchoolPro.Infra.Repositories
{
    public class StudentParentRepository : RepositoryBase<StudentParent>, IStudentParentRepository
    {
        public StudentParentRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
