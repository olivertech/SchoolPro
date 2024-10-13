
namespace SchoolPro.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //===============================
            // Add services to the container
            //===============================
            builder.Services
                .AddEndpointsApiExplorer()
                .AddSwaggerGen()
                .AddAutoMapper(typeof(Program))
                .AddControllers();

            //=============================
            // Referenciando o appsettings
            //=============================
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            //============================
            // Add Injection Dependencies
            //============================
            builder.Services.AddRepositoryDependenciesInjection(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
