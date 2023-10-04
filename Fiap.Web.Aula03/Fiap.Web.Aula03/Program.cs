using Fiap.Web.Aula03.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Recuperar a string de conexao do appsettings.json
var conexao = builder.Configuration.GetConnectionString("conexao");

//Configurar o injecao de dependencia do Contexto, utilizando tb a string de conexao
builder.Services.AddDbContext<HospitalContext>(op => op.UseSqlServer(conexao));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
