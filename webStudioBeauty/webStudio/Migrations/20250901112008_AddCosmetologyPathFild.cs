using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class AddCosmetologyPathFild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PathFolderImageUrl",
                table: "CosmetologyTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathFolderImageUrl",
                table: "CosmetologyTherapies");
        }
    }
}
