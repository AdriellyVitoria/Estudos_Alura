using MemotecaApi.Data;
using MemotecaApi.Services;
using Microsoft.EntityFrameworkCore;

namespace MemotecaApi;

public class Startup // Estrutura da api
{
    private readonly IConfiguration configuration;

    public Startup(IConfiguration configuration)
    {
        this.configuration=configuration;
    }

    public void ConfigureServices(IServiceCollection services) 
    {
        string connectionString = configuration.GetConnectionString("ContextConnection")!;

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseMySQL(connectionString); //conexao com o banco
        });

        services.AddScoped<IPensamentoService, PensamentoService>();

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //Passando a referencia do projeto inteiro
        services.AddControllers(); //Para pegar os controladores
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); //verifcar o ambiente
        }

        app.UseCors(b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); //acessor total

        app.UseRouting(); //ativar as rotas

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers(); //mapear endpoints 
        });
    }

    public void AddJsonFiles(IConfigurationBuilder builder, IWebHostEnvironment env)
    {
        builder
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json");
    }
}
