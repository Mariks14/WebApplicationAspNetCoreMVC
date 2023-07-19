using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplicationAspNetCoreMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// получаем строку подключения из файла конфигурации
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<ApplicationContext>(
//	options => options.UseSqlServer("DefaultConnection")); //This can be SQL Server or any other databse provider.

//// получаем строку подключения из файла конфигурации
//string connection = builder.Configuration.GetConnectionString("DefaultConnection");

//// добавляем контекст ApplicationContext в качестве сервиса в приложение
//builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

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

//app.MapGet("/", (ApplicationContext db) => db.Companies.ToList());

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
