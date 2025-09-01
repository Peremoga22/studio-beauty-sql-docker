using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webStudio.Migrations
{
    /// <inheritdoc />
    public partial class FixedModelDeleteFildCaregoryIdForCosmetologyCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CosmetologyTherapyCards_CosmetologyTherapies_CategoryId",
                table: "CosmetologyTherapyCards");

            migrationBuilder.DropIndex(
                name: "IX_CosmetologyTherapyCards_CategoryId",
                table: "CosmetologyTherapyCards");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CosmetologyTherapyCards");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CosmetologyTherapyCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
