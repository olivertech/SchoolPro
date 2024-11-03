namespace SchoolPro.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SchoolProDbContext? _context;

        private IAccessTokenRepository? _accessTokenRepository;
        private IClientRepository? _clientRepository;
        private IContactRepository? _contactRepository;
        private IDocumentRepository? _documentRepository;
        private IDocumentTypeRepository? _documentTypeRepository;
        private IFeatureRepository? _featureRepository;
        private IFeatureRoleRepository? _featureRoleRepository;
        private IFeeTypeRepository? _feeTypeRepository;
        private ISystemLogRepository? _systemLogRepository;
        private IParentRepository? _parentRepository;
        private IRoleRepository? _roleRepository;
        private IRoomRepository? _roomRepository;
        private ISchoolCalendarRepository? _schoolCalendarRepository;
        private ISchoolEnrollmentRepository? _schoolEnrollmentRepository;
        private ISchoolFeeRepository? _schoolFeeRepository;
        private ISchoolRepository? _schoolRepository;
        private ISchoolSubjectRepository? _schoolSubjectRepository;
        private ISchoolYearRepository? _schoolYearRepository;
        private IStudentClassRepository? _studentClassRepository;
        private IStudentGradeRepository? _studentGradeRepository;
        private IStudentRepository? _studentRepository;
        private ITeacherRepository? _teacherRepository;
        private ITeacherSchoolSubjectRepository? _teacherSchoolSubjectRepository;
        private IUserRepository? _userRepository;

        public UnitOfWork(SchoolProDbContext context)
        {
            _context = context;
        }

        public IAccessTokenRepository AccessTokenRepository => _accessTokenRepository ??= new AccessTokenRepository(_context!);

        public IClientRepository ClientRepository => _clientRepository ??= new ClientRepository(_context!);

        public IContactRepository ContactRepository => _contactRepository ??= new ContactRepository(_context!);

        public IDocumentRepository DocumentRepository => _documentRepository ??= new DocumentRepository(_context!);

        public IDocumentTypeRepository DocumentTypeRepository => _documentTypeRepository ?? new DocumentTypeRepository(_context!);

        public IFeatureRepository FeatureRepository => _featureRepository ?? new FeatureRepository(_context!);

        public IFeatureRoleRepository FeatureRoleRepository => _featureRoleRepository ?? new FeatureRoleRepository(_context!);

        public IFeeTypeRepository FeeTypeRepository => _feeTypeRepository ?? new FeeTypeRepository(_context!);

        public ISystemLogRepository SystemLogRepository => _systemLogRepository ?? new SystemLogRepository(_context!);

        public IParentRepository ParentRepository => _parentRepository ?? new ParentRepository(_context!);

        public IRoleRepository RoleRepository => RoleRepository?? new RoleRepository(_context!);

        public IRoomRepository RoomRepository => _roomRepository?? new RoomRepository(_context!);

        public ISchoolCalendarRepository SchoolCalendarRepository => _schoolCalendarRepository ?? new SchoolCalendarRepository(_context!);

        public ISchoolEnrollmentRepository SchoolEnrollmentRepository => _schoolEnrollmentRepository ?? new SchoolEnrollmentRepository(_context!);

        public ISchoolFeeRepository SchoolFeeRepository => _schoolFeeRepository ?? new SchoolFeeRepository(_context!);

        public ISchoolRepository SchoolRepository => _schoolRepository ?? new SchoolRepository(_context!);

        public ISchoolSubjectRepository SchoolSubjectRepository => _schoolSubjectRepository ?? new SchoolSubjectRepository(_context!);

        public ISchoolYearRepository SchoolYearRepository => _schoolYearRepository ?? new SchoolYearRepository(_context!);

        public IStudentClassRepository StudentClassRepository => _studentClassRepository ?? new StudentClassRepository(_context!);

        public IStudentGradeRepository StudentGradeRepository => _studentGradeRepository ?? new StudentGradeRepository(_context!);

        public IStudentRepository StudentRepository => _studentRepository ?? new StudentRepository(_context!);

        public ITeacherRepository TeacherRepository => _teacherRepository ?? new TeacherRepository(_context!);
        
        public ITeacherSchoolSubjectRepository TeacherSchoolSubjectRepository => _teacherSchoolSubjectRepository ?? new TeacherSchoolSubjectRepository(_context!);

        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context!);

        public async Task CommitAsync()
        {
            await _context!.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context!.Dispose();
        }
    }
}
