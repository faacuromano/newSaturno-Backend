using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Sa_Turno_BackEnd.Repository;
using System.Text;

namespace Sa_Turno_BackEnd
{
    // STARTUP NO SE INSTACIA, YA QUE PROGRAM CUMPLE ESA FUNCION
    // LA CLASE PROGRAM TIENE LA "RESPONSABILIDAD" DE CORRER NUESTRA APLICACION

    public static class Startup
    {
        public static WebApplication InitalizeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app; 
        }


        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Add services to the container.


            builder.Services.AddSwaggerGen(setupAction =>  
            {
                setupAction.AddSecurityDefinition("ConsultaAlumnosApiBearerAuth", new OpenApiSecurityScheme() //Esto va a permitir usar swagger con el token.
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    Description = "Acá pegar el token generado al loguearse."
                });

                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement 
                { 
                    {
                        new OpenApiSecurityScheme  
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "ConsultaAlumnosApiBearerAuth" 
                            } //Tiene que coincidir con el id seteado arriba en la definición

                        },  new List<string>()
                    }
                });
            });

            builder.Services.AddAuthentication("Bearer").AddJwtBearer //"Bearer" es el tipo de auntenticación que tenemos que elegir después en PostMan para pasarle el token

                (options => //Acá definimos la configuración de la autenticación. le decimos qué cosas queremos comprobar. La fecha de expiración se valida por defecto.
                {
                    options.TokenValidationParameters = new()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Authentication:Issuer"],
                        ValidAudience = builder.Configuration["Authentication:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Authentication:SecretForKey"]))
                    };
                });

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {

                        policy.WithOrigins("http://localhost:3000",
                                            "*");
                        policy.AllowAnyMethod();
                        policy.AllowAnyHeader();
                    });
            });

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            #region Injection
            builder.Services.AddSingleton<IClientRepository, ClientRepository>();
            builder.Services.AddSingleton<ITurnoRepository, TurnoRepository>();
            builder.Services.AddSingleton<IServicioRepository, ServicioRepository>();
            #endregion       
            
        }

        private static void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
