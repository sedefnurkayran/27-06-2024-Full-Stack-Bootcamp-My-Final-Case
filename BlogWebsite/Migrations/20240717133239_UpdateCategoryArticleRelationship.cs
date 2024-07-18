using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryArticleRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_categories_CategoryId1",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_CategoryId1",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "categories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryId1",
                table: "categories",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_categories_CategoryId1",
                table: "categories",
                column: "CategoryId1",
                principalTable: "categories",
                principalColumn: "CategoryId");
        }
    }
}
