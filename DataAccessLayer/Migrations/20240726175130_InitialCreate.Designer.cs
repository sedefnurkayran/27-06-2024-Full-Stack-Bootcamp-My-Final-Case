﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240726175130_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4");

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

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImagel")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("AboutID");

                    b.ToTable("abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogImage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogThumbnailImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WriterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WriterId");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
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
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("TEXT");

                    b.Property<int>("WriterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.HasIndex("WriterId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("MailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MailStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("MailId");

                    b.ToTable("newsLetters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UserComment", b =>
                {
                    b.Property<int>("UserCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserCommentId");

                    b.ToTable("userComments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("WriterAbout")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterPassword")
                        .HasColumnType("TEXT");

                    b.Property<bool>("WriterStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("WriterId");

                    b.ToTable("writers");
                });

            modelBuilder.Entity("BlogTag", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", null)
                        .WithMany()
                        .HasForeignKey("BlogsBlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Writer", "Writer")
                        .WithMany("Blogs")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Writer", "Writer")
                        .WithMany("Comments")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
