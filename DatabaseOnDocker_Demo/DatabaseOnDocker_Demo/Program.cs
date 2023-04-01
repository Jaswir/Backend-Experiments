using DatabaseOnDocker_Demo.Data;
using DatabaseOnDocker_Demo.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var server = builder.Configuration["DatabaseServer"] ?? "";
var port = builder.Configuration["DatabasePort"] ?? "";
var user = builder.Configuration["DatabaseUser"] ?? "";
var password = builder.Configuration["DatabasePassword"] ?? "";
var database = builder.Configuration["DatabaseName"] ?? "";

var connectionString = $"Server={server}, {port}; Initial Catalog={database}; User ID={user}; Password={password}";


builder.Services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//DatabaseManagementService.MigrationInitialization(app);

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
