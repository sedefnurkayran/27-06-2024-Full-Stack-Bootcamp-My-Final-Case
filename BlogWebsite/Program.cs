using System.Security.Permissions;
using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.DAL.Concrete.EfCore;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
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
builder.Services.AddScoped<IAboutDal, EfAboutRepository>();
builder.Services.AddScoped<IBlogDal, EfBlogRepository>();
builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();
builder.Services.AddScoped<ICommentDal, EfCommentRepository>();
builder.Services.AddScoped<IConctactDal, EfContactRepository>();
builder.Services.AddScoped<INewsLetterDal, EfNewsLetterRepository>();
builder.Services.AddScoped<IWriterDal, EfWriterRepository>();

// builder.Services.AddScoped<AboutManager>();
// builder.Services.AddScoped<CommentManager>();

//AUTH MY
// public void ConfigureServices(IServiceCollection services)
// {

//     //builder.Services.AddControllersWithViews();  
//     services.AddMvc(config =>
//     {
//         var policy = new AuthorizationPolicyBuilder()
//                     .RequireAuthenticatedUser()
//                     .Build();
//         config.Filters.Add(new AuthorizeFilter(policy));
//     });
// }

//COOKIE ILE AUTHENTICATION 
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
builder.Services.AddSession();


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

// app.UseStatusCodePages(); //for 404 Error Page 
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?Code={0}"); //Sd

app.UseHttpsRedirection();
app.UseStaticFiles();  //web projesi sablonu kullansaydim bunu ekleyecektim. wwwroot icn.

app.UseSession(); //sessionu kullan - sd
app.UseRouting();

app.UseAuthentication(); //Sd

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
