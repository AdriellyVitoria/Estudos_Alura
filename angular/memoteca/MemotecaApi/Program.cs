using MemotecaApi;
using MemotecaApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);

startup.AddJsonFiles(builder.Configuration, builder.Environment);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>(); //conexao com o banco 
    db.Database.Migrate(); //app as migrate
}

startup.Configure(app, app.Environment);

app.Run();