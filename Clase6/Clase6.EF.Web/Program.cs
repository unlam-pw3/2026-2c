using System;
using Clase6.EF.Entidades;
using Clase6.EF.Logica;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

using var db = new JugueteriaDbContext();
db.Database.Migrate();
JuguetesDbInicializaciones.Inicializar(db);


// Add services to the container.
builder.Services.AddControllersWithViews();

//el tiempo de vida es un Request
builder.Services.AddScoped<IJuguetesLogica, JuguetesLogica>();
builder.Services.AddScoped<IFabricantesLogica, FabricantesLogica>();

//singleton
//el tiempo de vida es toda la aplicacion
//builder.Services.AddSingleton<IJuguetesLogica, JuguetesLogica>();

//transient
//el tiempo de vida es cada vez que se solicita el servicio
//builder.Services.AddTransient<IJuguetesLogica, JuguetesLogica>();



//add JugueteriaDbContext
builder.Services.AddDbContext<JugueteriaDbContext>();


var app = builder.Build();

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
