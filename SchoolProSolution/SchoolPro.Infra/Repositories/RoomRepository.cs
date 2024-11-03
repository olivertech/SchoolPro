namespace SchoolPro.Infra.Repositories
{
    public class RoomRepository : RepositoryAuthorizedBase<Room>, IRoomRepository
    {
        public RoomRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
