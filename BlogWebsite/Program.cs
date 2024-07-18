using BlogApp.Data.Concrete.EfCore;
using BlogWebsite.DAL;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.DAL.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();   //Controllerlari Viewslerle birlikte kullansin.

//DbConnection
builder.Services.AddDbContext<DataContext>(options =>
{
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("database");
    options.UseSqlite(connectionString);
});

//Ya da 
// builder.Services.AddDbContext<DataContext>(options =>
// {
//     options.UseSqlite(builder.Configuration["ConnectionStrings:sql_connection"]);
// });
//bu daha kisasi.

builder.Services.AddScoped<IBlogRepository, EfBlogRepository>();

var app = builder.Build();

//SEEDDATA YI KULLANSIN.
SeedData.TestVerileriniDoldur(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();  //web projesi sablonu kullansaydim bunu ekleyecektim. wwwroot icn.

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
