using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using sklep.Data;
using sklep.Models;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja po³¹czenia z baz¹ danych (SQLite lub inna)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Konfiguracja to¿samoœci u¿ytkowników (Identity)
builder.Services.AddIdentity<UserModel, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Dodanie obs³ugi MVC (widoki + kontrolery)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Obs³uga plików statycznych (CSS, JS)
app.UseStaticFiles();

// Konfiguracja routingu
app.UseRouting();

// Obs³uga uwierzytelniania i autoryzacji
app.UseAuthentication();
app.UseAuthorization();

// Mapowanie domyœlnej trasy
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Uruchomienie aplikacji
app.Run();
