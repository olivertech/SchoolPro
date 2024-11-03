using SchoolPro.Infra.Repositories;

namespace SchoolPro.Infra.Dependencies
{
    /// <summary>
    /// Classe estática que concentra as configurações
    /// da conexão com os banco de dados e registros 
    /// de injeções de dependência
    /// </summary>
    public static class RepositoryDependenciesInjection
    {
        public static IServiceCollection AddRepositoryDependenciesInjection(this IServiceCollection services, IConfiguration configuration)
        {
            //PostGreSql Database Configuration
            services.AddDbContext<SchoolProDbContext>(options =>
                                                options.UseNpgsql(
                                                    configuration.GetConnectionString("DefaultConnectionString"))
                                                );
            //Repositories injections
            services.AddScoped<IAccessTokenRepository, AccessTokenRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IFeatureRoleRepository, FeatureRoleRepository>();
            services.AddScoped<IFeeTypeRepository, FeeTypeRepository>();
            services.AddScoped<IParentRepository, ParentRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<ISchoolCalendarRepository, SchoolCalendarRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<ISchoolEnrollmentRepository, SchoolEnrollmentRepository>();
            services.AddScoped<ISchoolFeeRepository, SchoolFeeRepository>();
            services.AddScoped<ISchoolSubjectRepository, SchoolSubjectRepository>();
            services.AddScoped<ISchoolYearRepository, SchoolYearRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentGradeRepository, StudentGradeRepository>();
            services.AddScoped<IStudentClassRepository, StudentClassRepository>();
            services.AddScoped<IStudentParentRepository, StudentParentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ITeacherSchoolSubjectRepository, TeacherSchoolSubjectRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();

            ////Others
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
