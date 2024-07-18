﻿// <auto-generated />
using System;
using BlogWebsite.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogWebsite.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240717131021_relationsArticletoComment")]
    partial class relationsArticletoComment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4");

            modelBuilder.Entity("BlogWebsite.Models.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutDetails1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutDetails2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImagel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutMapLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("AboutID");

                    b.ToTable("abouts");
                });

            modelBuilder.Entity("BlogWebsite.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArticleContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ArticleCreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ArticleStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArticleThumbnailImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticleId");

                    b.HasIndex("CategoryId");

                    b.ToTable("articles");
                });

            modelBuilder.Entity("BlogWebsite.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryId1");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("BlogWebsite.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CommentCreateDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentUserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentUserSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.HasIndex("ArticleId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("BlogWebsite.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMessage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactSubject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("BlogWebsite.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserMail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BlogWebsite.Models.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("UserTypeStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserTypeId");

                    b.ToTable("userTypes");
                });

            modelBuilder.Entity("BlogWebsite.Models.Article", b =>
                {
                    b.HasOne("BlogWebsite.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogWebsite.Models.Category", b =>
                {
                    b.HasOne("BlogWebsite.Models.Category", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId1");
                });

            modelBuilder.Entity("BlogWebsite.Models.Comment", b =>
                {
                    b.HasOne("BlogWebsite.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("BlogWebsite.Models.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BlogWebsite.Models.Category", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}