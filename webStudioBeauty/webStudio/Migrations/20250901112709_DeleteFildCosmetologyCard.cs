using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class DeleteFildCosmetologyCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmetologyTherapyCards_CosmetologyTherapies_CategoryId1",
                table: "CosmetologyTherapyCards");

            migrationBuilder.DropIndex(
                name: "IX_CosmetologyTherapyCards_CategoryId1",
                table: "CosmetologyTherapyCards");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "CosmetologyTherapyCards");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CosmetologyTherapyCards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyTherapyCards_CategoryId",
                table: "CosmetologyTherapyCards",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CosmetologyTherapyCards_CosmetologyTherapies_CategoryId",
                table: "CosmetologyTherapyCards",
                column: "CategoryId",
                principalTable: "CosmetologyTherapies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmetologyTherapyCards_CosmetologyTherapies_CategoryId",
                table: "CosmetologyTherapyCards");

            migrationBuilder.DropIndex(
                name: "IX_CosmetologyTherapyCards_CategoryId",
                table: "CosmetologyTherapyCards");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "CosmetologyTherapyCards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "CosmetologyTherapyCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CosmetologyTherapyCards_CategoryId1",
                table: "CosmetologyTherapyCards",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CosmetologyTherapyCards_CosmetologyTherapies_CategoryId1",
                table: "CosmetologyTherapyCards",
                column: "CategoryId1",
                principalTable: "CosmetologyTherapies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
