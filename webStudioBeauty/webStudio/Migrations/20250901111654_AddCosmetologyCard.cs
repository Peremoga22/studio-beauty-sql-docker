using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class AddCosmetologyCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmetologyTherapies_Categories_CategoryId1",
                table: "CosmetologyTherapies");

            migrationBuilder.DropIndex(
                name: "IX_CosmetologyTherapies_CategoryId1",
                table: "CosmetologyTherapies");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "CosmetologyTherapies");

            migrationBuilder.DropColumn(
                name: "DescriptionCard",
                table: "CosmetologyTherapies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "CosmetologyTherapies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CosmetologyTherapies");

            migrationBuilder.DropColumn(
                name: "TitleCard",
                table: "CosmetologyTherapies");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CosmetologyTherapies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "CosmetologyTherapyCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmetologyTherapyCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CosmetologyTherapyCards_CosmetologyTherapies_CategoryId1",
                        column: x => x.CategoryId1,
                        principalTable: "CosmetologyTherapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyTherapies_CategoryId",
                table: "CosmetologyTherapies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyTherapyCards_CategoryId1",
                table: "CosmetologyTherapyCards",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CosmetologyTherapies_Categories_CategoryId",
                table: "CosmetologyTherapies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmetologyTherapies_Categories_CategoryId",
                table: "CosmetologyTherapies");

            migrationBuilder.DropTable(
                name: "CosmetologyTherapyCards");

            migrationBuilder.DropIndex(
                name: "IX_CosmetologyTherapies_CategoryId",
                table: "CosmetologyTherapies");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "CosmetologyTherapies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "CosmetologyTherapies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionCard",
                table: "CosmetologyTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "CosmetologyTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CosmetologyTherapies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TitleCard",
                table: "CosmetologyTherapies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyTherapies_CategoryId1",
                table: "CosmetologyTherapies",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CosmetologyTherapies_Categories_CategoryId1",
                table: "CosmetologyTherapies",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
