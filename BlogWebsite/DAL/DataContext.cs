using BlogApp.Models;
using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace BlogWebsite.DAL
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<About> abouts => Set<About>();
        public DbSet<Blog> blogs => Set<Blog>();
        public DbSet<Category> categories => Set<Category>();
        public DbSet<Comment> comments => Set<Comment>();
        public DbSet<Contact> contacts => Set<Contact>();
        public DbSet<Tag> Tags => Set<Tag>();

        public DbSet<Writer> writers => Set<Writer>();
        public DbSet<NewsLetter> newsLetters => Set<NewsLetter>();
        public DbSet<UserComment> userComments => Set<UserComment>();
        //public DbSet<UserType> userTypes => Set<UserType>();

    }
}