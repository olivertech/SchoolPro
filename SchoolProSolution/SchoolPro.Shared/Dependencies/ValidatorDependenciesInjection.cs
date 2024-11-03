namespace SchoolPro.Shared.Dependencies
{
    /// <summary>
    /// Classe estática que concentra as configurações
    /// da conexão com os banco de dados e registros 
    /// de injeções de dependência
    /// </summary>
    public static class ValidatorDependenciesInjection
    {
        public static IServiceCollection AddValidatorDependenciesInjection(this IServiceCollection services)
        {
            //Validators injections
            services.AddScoped<IValidator<LoginRequest>, LoginRequestValidator>();

            return services;
        }
    }
}
