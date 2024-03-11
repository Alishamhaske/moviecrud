using Microsoft.EntityFrameworkCore;
using moviecrud.Data;
using moviecrud.Repositories;
using moviecrud.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var ConnectionStrings = builder.Configuration.GetConnectionString("defaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(op=>op.UseSqlServer(ConnectionStrings));


builder.Services.AddScoped<IMovieRepository, MovieRepository>();    
builder.Services.AddScoped<IMovieServices,MovieServices>();

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
