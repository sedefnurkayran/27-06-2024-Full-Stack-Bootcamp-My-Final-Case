﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogWebsite.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240718181822_TagClass")]
    partial class TagClass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4");

            modelBuilder.Entity("BlogApp.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BlogTag", b =>
                {
                    b.Property<int>("BlogsBlogId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BlogsBlogId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("BlogTag");
                });

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

            modelBuilder.Entity("BlogWebsite.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogThumbnailImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("BlogWebsite.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("BlogWebsite.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
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

                    b.HasIndex("BlogId");

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

                    b.Property<int>("UserTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

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

            modelBuilder.Entity("BlogTag", b =>
                {
                    b.HasOne("BlogWebsite.Models.Blog", null)
                        .WithMany()
                        .HasForeignKey("BlogsBlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogApp.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebsite.Models.Blog", b =>
                {
                    b.HasOne("BlogWebsite.Models.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogWebsite.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogWebsite.Models.Comment", b =>
                {
                    b.HasOne("BlogWebsite.Models.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("BlogWebsite.Models.User", b =>
                {
                    b.HasOne("BlogWebsite.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("BlogWebsite.Models.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BlogWebsite.Models.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("BlogWebsite.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
