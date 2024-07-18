using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebsite.Migrations
{
    /// <inheritdoc />
    public partial class ArticleNameChangingtoBlog2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_articles_ArticleId",
                table: "comments");

            migrationBuilder.DropTable(
                name: "articles");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "comments",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_comments_ArticleId",
                table: "comments",
                newName: "IX_comments_BlogId");

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogTitle = table.Column<string>(type: "TEXT", nullable: false),
                    BlogContent = table.Column<string>(type: "TEXT", nullable: false),
                    BlogThumbnailImage = table.Column<string>(type: "TEXT", nullable: false),
                    BlogImage = table.Column<string>(type: "TEXT", nullable: false),
                    BlogCreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_blogs_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogs_CategoryId",
                table: "blogs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "comments",
                newName: "ArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_comments_BlogId",
                table: "comments",
                newName: "IX_comments_ArticleId");

            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArticleContent = table.Column<string>(type: "TEXT", nullable: false),
                    ArticleCreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ArticleImage = table.Column<string>(type: "TEXT", nullable: false),
                    ArticleStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    ArticleThumbnailImage = table.Column<string>(type: "TEXT", nullable: false),
                    ArticleTitle = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_articles_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_articles_CategoryId",
                table: "articles",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_articles_ArticleId",
                table: "comments",
                column: "ArticleId",
                principalTable: "articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
