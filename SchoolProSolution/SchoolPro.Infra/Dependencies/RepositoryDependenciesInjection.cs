﻿namespace SchoolPro.Infra.Dependencies
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
            //services.AddScoped<IContainerDbRepository, ContainerDbRepository>();
            //services.AddScoped<ITenantRepository, TenantRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IAccessTokenRepository, AccessTokenRepository>();
            //services.AddScoped<IPortRepository, PortRepository>();
            //services.AddScoped<IFeatureRepository, FeatureRepository>();
            //services.AddScoped<IUserFeatureRepository, UserFeatureRepository>();
            //services.AddScoped<ILogAccessRepository, LogAccessRepository>();
            //services.AddScoped<IRoleRepository, RoleRepository>();
            //services.AddScoped<IMenuRepository, MenuRepository>();
            //services.AddScoped<IRoleMenuRepository, RoleMenuRepository>();
            //services.AddScoped<ISecretRepository, SecretRepository>();

            ////Others
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IPortFinder, PortFinderHelper>();

            return services;
        }
    }
}
