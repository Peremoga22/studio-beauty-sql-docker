using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class addMessageCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageTherapies_Categories_CategoryId1",
                table: "MessageTherapies");

            migrationBuilder.DropIndex(
                name: "IX_MessageTherapies_CategoryId1",
                table: "MessageTherapies");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "MessageTherapies");

            migrationBuilder.DropColumn(
                name: "DescriptionCard",
                table: "MessageTherapies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MessageTherapies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "MessageTherapies");

            migrationBuilder.DropColumn(
                name: "TitleCard",
                table: "MessageTherapies");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "MessageTherapies",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_MessageTherapies_CategoryId",
                table: "MessageTherapies",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageTherapies_Categories_CategoryId",
                table: "MessageTherapies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageTherapies_Categories_CategoryId",
                table: "MessageTherapies");

            migrationBuilder.DropIndex(
                name: "IX_MessageTherapies_CategoryId",
                table: "MessageTherapies");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "MessageTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "MessageTherapies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionCard",
                table: "MessageTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MessageTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "MessageTherapies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TitleCard",
                table: "MessageTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_MessageTherapies_CategoryId1",
                table: "MessageTherapies",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageTherapies_Categories_CategoryId1",
                table: "MessageTherapies",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
