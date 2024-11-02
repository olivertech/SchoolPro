namespace SchoolPro.Infra.Repositories
{
    public class RoomRepository : RepositoryBase<Room>, IRoomRepository
    {
        public RoomRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
