using Microsoft.EntityFrameworkCore;
using ProyectoFinal_MVC.Data;
using ProyectoFinal_MVC.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<EmpresaConstructoraServices>();
builder.Services.AddScoped<TrabajadorServices>();
builder.Services.AddScoped<ConstruccionServices>();
//configuracion db
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProyectoFinal_MVCDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("WebConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
