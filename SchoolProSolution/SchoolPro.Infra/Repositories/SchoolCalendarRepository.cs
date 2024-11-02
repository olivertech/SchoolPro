namespace SchoolPro.Infra.Repositories
{
    public class SchoolCalendarRepository : RepositoryBase<SchoolCalendar>, ISchoolCalendarRepository
    {
        public SchoolCalendarRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
