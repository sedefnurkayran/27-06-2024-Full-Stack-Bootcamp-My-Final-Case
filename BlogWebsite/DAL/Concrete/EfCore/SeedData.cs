using BlogApp.Models;
using BlogWebsite.DAL;
using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{

    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {

            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<DataContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                //Benim eklediklerim

                if (!context.categories.Any())
                {
                    context.categories.AddRange(
                        new Category { CategoryName = "ürdün", CategoryStatus = true },
                        new Category { CategoryName = "misir", CategoryStatus = true },
                        new Category { CategoryName = "bosna hersek", CategoryStatus = true },
                        new Category { CategoryName = "sirbistan", CategoryStatus = true },
                        new Category { CategoryName = "türkiye", CategoryStatus = true }
                    );
                    context.SaveChanges();
                }

                //Benim eklediklerim

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "web prograglama" },
                        new Tag { Text = "full-stack" },
                        new Tag { Text = "game" },
                        new Tag { Text = "backend" },
                        new Tag { Text = "frounded" }
                    );
                    context.SaveChanges();
                }
                if (!context.users.Any())
                {
                    context.users.AddRange(
                       new User { UserName = "ahmetkaya", UserMail = "ahmetkaya@example.com", UserPassword = "password", UserStatus = true },
                        new User { UserName = "sinankarabulut", UserMail = "sinankarabulut@example.com", UserPassword = "sdfserfd", UserStatus = true }

                    );
                    context.SaveChanges();
                }
                if (!context.blogs.Any())
                {
                    context.blogs.AddRange(
                        new Blog
                        {
                            BlogTitle = "Asp.net Core",
                            BlogContent = "asp.net core güzel bir kütüphanedir.",
                            BlogStatus = true,
                            BlogCreateDate = DateTime.Now.AddDays(-15),
                            Tags = context.Tags.Take(3).ToList(),
                            BlogImage = "~/img/3.png",
                            UserId = 1,
                            CategoryId = 1,
                            Comments = context.comments.Take(1).ToList()
                        },
                        new Blog
                        {
                            BlogTitle = "Unity ile oyun geliştirme",
                            BlogContent = "Unity editörü ile oyunlar geliştirebilirsiniz.",
                            BlogStatus = true,
                            BlogCreateDate = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(2).ToList(),
                            BlogImage = "~/img/2.png",
                            UserId = 2,
                            CategoryId = 1,
                            Comments = context.comments.Take(1).ToList()
                        },
                        new Blog
                        {
                            BlogTitle = "Full Stack Developer Olmak",
                            BlogContent = "Full Stack Developer Olmak Güzeldir.",
                            BlogStatus = true,
                            BlogCreateDate = DateTime.Now.AddDays(-5),
                            Tags = context.Tags.Take(4).ToList(),
                            BlogImage = "~/img/1.png",
                            UserId = 1,
                            CategoryId = 1,
                            Comments = context.comments.Take(1).ToList()
                        }
                    );
                    context.SaveChanges();
                }



                //Benim
                if (!context.comments.Any())
                {


                    context.comments.AddRange(
                        new Comment { BlogId = 1, CommentUserName = "User1", CommentCreateDate = DateTime.Now, CommentStatus = true, CommentTitle = "Comment1", CommentUserSurname = "Surname1", UserId = 1 }

                        // new Comment { CommentTitle = "harika", BlogId = 1 },
                        // new Comment { CommentTitle = "cok güzel", BlogId = 1 },
                        // new Comment { CommentTitle = "mükemmel", BlogId = 3 },
                        // new Comment { CommentTitle = "süper", BlogId = 1 },
                        // new Comment { CommentTitle = "cok iyi", BlogId = 2 }
                    );
                    context.SaveChanges();
                }

            }
        }
    }
}