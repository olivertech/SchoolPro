namespace SchoolPro.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAccessTokenRepository AccessTokenRepository { get; }
        IClientRepository ClientRepository { get; }
        IContactRepository ContactRepository { get; }
        IDocumentRepository DocumentRepository { get; }
        IDocumentTypeRepository DocumentTypeRepository { get; }
        IFeatureRepository FeatureRepository { get; }
        IFeatureRoleRepository FeatureRoleRepository { get; }
        IFeeTypeRepository FeeTypeRepository { get; }
        IParentRepository ParentRepository { get; }
        IRoleRepository RoleRepository { get; }
        IRoomRepository RoomRepository { get; }
        ISchoolCalendarRepository SchoolCalendarRepository { get; }
        ISchoolEnrollmentRepository SchoolEnrollmentRepository { get; }
        ISchoolFeeRepository SchoolFeeRepository { get; }
        ISchoolRepository SchoolRepository { get; }
        ISchoolSubjectRepository SchoolSubjectRepository { get; }
        ISchoolYearRepository SchoolYearRepository { get; }
        IStudentClassRepository StudentClassRepository { get; }
        IStudentGradeRepository StudentGradeRepository { get; }
        IStudentRepository StudentRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        ITeacherSchoolSubjectRepository TeacherSchoolSubjectRepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        IUserRepository UserRepository { get; }

        Task CommitAsync();
    }
}
