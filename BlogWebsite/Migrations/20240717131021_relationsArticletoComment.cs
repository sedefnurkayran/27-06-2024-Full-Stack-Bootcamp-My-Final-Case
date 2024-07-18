using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebsite.Migrations
{
    /// <inheritdoc />
    public partial class relationsArticletoComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comments_ArticleId",
                table: "comments",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_articles_ArticleId",
                table: "comments",
                column: "ArticleId",
                principalTable: "articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_articles_ArticleId",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_ArticleId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "comments");
        }
    }
}
