using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebsite.Migrations
{
    /// <inheritdoc />
    public partial class userandTypeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserTypeId",
                table: "users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_users_UserTypeId",
                table: "users",
                column: "UserTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_userTypes_UserTypeId",
                table: "users",
                column: "UserTypeId",
                principalTable: "userTypes",
                principalColumn: "UserTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_userTypes_UserTypeId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserTypeId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "users");
        }
    }
}
