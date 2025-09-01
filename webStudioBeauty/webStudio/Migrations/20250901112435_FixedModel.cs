using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class FixedModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathFolderImageUrl",
                table: "CosmetologyTherapies");

            migrationBuilder.AddColumn<string>(
                name: "PathFolderImageUrl",
                table: "CosmetologyTherapyCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathFolderImageUrl",
                table: "CosmetologyTherapyCards");

            migrationBuilder.AddColumn<string>(
                name: "PathFolderImageUrl",
                table: "CosmetologyTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
