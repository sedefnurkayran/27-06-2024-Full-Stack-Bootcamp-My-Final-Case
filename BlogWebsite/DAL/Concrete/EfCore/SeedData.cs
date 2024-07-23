using BlogApp.Models;
using BlogWebsite.DAL;
using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebsite.DAL.Concrete.EfCore
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
                if (!context.writers.Any())
                {
                    context.writers.AddRange(
                       new Writer { WriterName = "ahmetkaya", WriterMail = "ahmetkaya@example.com", WriterPassword = "password", WriterStatus = true },
                        new Writer { WriterName = "sinankarabulut", WriterMail = "sinankarabulut@example.com", WriterPassword = "sdfserfd", WriterStatus = true }

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
                            WriterId = 1,
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
                            WriterId = 2,
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
                            WriterId = 1,
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
                        new Comment { BlogId = 1, CommentUserName = "User1", CommentCreateDate = DateTime.Now, CommentStatus = true, CommentTitle = "Comment1", WriterId = 1 }

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