namespace SchoolPro.Infra.Repositories
{
    public class SchoolCalendarRepository : RepositoryAuthorizedBase<SchoolCalendar>, ISchoolCalendarRepository
    {
        public SchoolCalendarRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
