using Microsoft.EntityFrameworkCore;
using Programando.CSharp.WebApplication1.Model;

var builder = WebApplication.CreateBuilder(args);


// SERVICIOS o INYECCION DE DEPENDENCIAS

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ModelNorthwind>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Northwind")));

builder.Services.AddHttpClient(); 

var app = builder.Build();


/////////////////////
// MIDDLEWERE
/////////////////////



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
