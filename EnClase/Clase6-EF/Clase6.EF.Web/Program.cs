using System;
using Clase6.EF.Entidades;
using Clase6.EF.Logica;
using Clase6.EF.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IJuguetesLogica, JuguetesLogica>();
builder.Services.AddScoped<ITematicaLogica, TematicaLogica>();
builder.Services.AddScoped<ISucursalLogica, SucursalLogica>();
builder.Services.AddHttpClient<IGutendexLogica, GutendexLogica>();
builder.Services.AddScoped<IPaginasLogica, PaginasLogica>();
builder.Services.AddScoped<ILibroRepositorio, LibroRepositorio>();
builder.Services.AddScoped<ILibroLogica, LibroLogica>();

//add JugueteriaDbContext
builder.Services.AddDbContext<JugueteriaDbContext>();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<JugueteriaDbContext>();
    db.Database.Migrate();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Juguetes}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
