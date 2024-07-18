using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace BlogWebsite.DAL
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<About> abouts => Set<About>();
        public DbSet<Article> articles => Set<Article>();
        public DbSet<Category> categories => Set<Category>();
        public DbSet<Comment> comments => Set<Comment>();
        public DbSet<Contact> contacts => Set<Contact>();
        public DbSet<User> users => Set<User>();
        public DbSet<UserType> userTypes => Set<UserType>();

    }
}