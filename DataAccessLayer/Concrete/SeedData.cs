﻿using EntityLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;



namespace DataAccessLayer.Concrete
{

    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {

            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<Context>();

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
                            BlogTitle = "Jordan",
                            BlogContent = "'Rose-red city' world wonder: Petra.",
                            BlogStatus = true,
                            BlogCreateDate = DateTime.Now.AddDays(-15),
                            Tags = context.Tags.Take(3).ToList(),
                            BlogImage = "/img/petra1.jpg",
                            WriterId = 1,
                            CategoryId = 1,
                            Comments = context.comments.Take(1).ToList()
                        },
                        new Blog
                        {
                            BlogTitle = "Bosnia and Herzegovina",
                            BlogContent = "Natural Wonder Vrelo Bosnia National Park.",
                            BlogStatus = true,
                            BlogCreateDate = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(2).ToList(),
                            BlogImage = "/img/bosna.jpg",
                            WriterId = 2,
                            CategoryId = 3,
                            Comments = context.comments.Take(1).ToList()
                        },
                        new Blog
                        {
                            BlogTitle = "Wadi Rum",
                            BlogContent = "This Is Not Mars, This Is Wadi Rum!",
                            BlogStatus = true,
                            BlogCreateDate = DateTime.Now.AddDays(-5),
                            Tags = context.Tags.Take(4).ToList(),
                            BlogImage = "/img/wadirum2.jpg",
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
