using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebsite.Migrations
{
    /// <inheritdoc />
    public partial class CategoryRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "categories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "articles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryId1",
                table: "categories",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_articles_CategoryId",
                table: "articles",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_articles_categories_CategoryId",
                table: "articles",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_categories_categories_CategoryId1",
                table: "categories",
                column: "CategoryId1",
                principalTable: "categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_categories_CategoryId",
                table: "articles");

            migrationBuilder.DropForeignKey(
                name: "FK_categories_categories_CategoryId1",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_CategoryId1",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_articles_CategoryId",
                table: "articles");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "articles");
        }
    }
}
