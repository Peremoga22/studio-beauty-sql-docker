using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class DeleteApointmentUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AppointmentUsers_UserId1",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UserId1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUserId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AppointmentUserId",
                table: "Categories",
                column: "AppointmentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AppointmentUsers_AppointmentUserId",
                table: "Categories",
                column: "AppointmentUserId",
                principalTable: "AppointmentUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AppointmentUsers_AppointmentUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AppointmentUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AppointmentUserId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId1",
                table: "Categories",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AppointmentUsers_UserId1",
                table: "Categories",
                column: "UserId1",
                principalTable: "AppointmentUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
