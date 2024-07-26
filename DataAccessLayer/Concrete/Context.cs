using System.Security.Cryptography;
using EntityLayer.Concrete;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{

    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options) { }

        
        public DbSet<About> abouts => Set<About>();
        public DbSet<Blog> blogs => Set<Blog>();
        public DbSet<Category> categories => Set<Category>();
        public DbSet<Comment> comments => Set<Comment>();
        public DbSet<Contact> contacts => Set<Contact>();
        public DbSet<Tag> Tags => Set<Tag>();

        public DbSet<Writer> writers => Set<Writer>();
        public DbSet<NewsLetter> newsLetters => Set<NewsLetter>();
        public DbSet<UserComment> userComments => Set<UserComment>();

    }


}
