using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentUseIsConfirmed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "AppointmentUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "AppointmentUsers");
        }
    }
}
