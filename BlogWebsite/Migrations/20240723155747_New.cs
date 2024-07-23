using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebsite.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_users_UserId",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_users_UserId",
                table: "comments");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropIndex(
                name: "IX_comments_UserId",
                table: "comments");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "blogs",
                newName: "WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_UserId",
                table: "blogs",
                newName: "IX_blogs_WriterId");

            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "writers",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WriterName = table.Column<string>(type: "TEXT", nullable: true),
                    WriterAbout = table.Column<string>(type: "TEXT", nullable: true),
                    WriterImage = table.Column<string>(type: "TEXT", nullable: true),
                    WriterMail = table.Column<string>(type: "TEXT", nullable: true),
                    WriterPassword = table.Column<string>(type: "TEXT", nullable: true),
                    WriterStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writers", x => x.WriterId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_WriterId",
                table: "comments",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_writers_WriterId",
                table: "blogs",
                column: "WriterId",
                principalTable: "writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_writers_WriterId",
                table: "comments",
                column: "WriterId",
                principalTable: "writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_writers_WriterId",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_writers_WriterId",
                table: "comments");

            migrationBuilder.DropTable(
                name: "writers");

            migrationBuilder.DropIndex(
                name: "IX_comments_WriterId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "comments");

            migrationBuilder.RenameColumn(
                name: "WriterId",
                table: "blogs",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_WriterId",
                table: "blogs",
                newName: "IX_blogs_UserId");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserAbout = table.Column<string>(type: "TEXT", nullable: true),
                    UserImage = table.Column<string>(type: "TEXT", nullable: true),
                    UserMail = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    UserPassword = table.Column<string>(type: "TEXT", nullable: true),
                    UserStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_UserId",
                table: "comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_users_UserId",
                table: "blogs",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_users_UserId",
                table: "comments",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
