namespace SchoolPro.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //====================================
            // Configura��o da Session do sistema
            //====================================
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20); // Define a dura��o da sess�o
                options.Cookie.HttpOnly = true; // Aumenta a seguran�a
                options.Cookie.IsEssential = true; // Necess�rio para que a sess�o funcione
            });

            //====================================
            // Adiciona o servi�o In-Memory Cache
            //====================================
            builder.Services.AddMemoryCache();

            //=================================================
            // Configura autentica��o por token gerada via JWT
            //=================================================
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.UseSecurityTokenValidators = true;
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidIssuer = JwtSettings.JwtIssuer,
                    ValidAudience = JwtSettings.JwtAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtSettings.SecretKey)),
                    RequireExpirationTime = true,
                    ClockSkew = TimeSpan.Zero,
                };
            });

            //===============================
            // Adiciona outros middlewares
            //===============================
            builder.Services
                .AddEndpointsApiExplorer()
                //Cria o bot�o de autoriza��o no Swagger
                .AddSwaggerGen(option =>
                {
                    option.SwaggerDoc("v1", new OpenApiInfo { Title = "SchoolPro.Api", Version = "v1" });
                    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                    {
                        In = ParameterLocation.Header,
                        Description = "JWT Authorization header using the Bearer scheme.",
                        Name = "Authorization",
                        Type = SecuritySchemeType.Http,
                        BearerFormat = "JWT",
                        Scheme = "Bearer"
                    });
                    option.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            Array.Empty<string>()
                        }
                    });
                })
                .AddAutoMapper(typeof(Program))
                .AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
                    options.JsonSerializerOptions.WriteIndented = true;
                })
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //=============================
            // Referenciando o appsettings
            //=============================
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            //============================================
            // Adciona classe de injec��o de depend�ncias
            //============================================
            builder.Services.AddRepositoryDependenciesInjection(builder.Configuration);
            builder.Services.AddValidatorDependenciesInjection();

            //================================================================
            // Adiciona globalmente o filtro de valida��o do cache do usu�rio 
            //================================================================
            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<CacheCheckAttribute>();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
