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

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:3000",
                                            "*");
                    });
            });

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();
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
