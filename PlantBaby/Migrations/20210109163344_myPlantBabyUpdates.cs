using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantBaby.Migrations
{
    public partial class myPlantBabyUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyPlantBabies_PlantParents_PlantParentId",
                table: "MyPlantBabies");

            migrationBuilder.AlterColumn<int>(
                name: "PlantParentId",
                table: "MyPlantBabies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyPlantBabies_PlantParents_PlantParentId",
                table: "MyPlantBabies",
                column: "PlantParentId",
                principalTable: "PlantParents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyPlantBabies_PlantParents_PlantParentId",
                table: "MyPlantBabies");

            migrationBuilder.AlterColumn<int>(
                name: "PlantParentId",
                table: "MyPlantBabies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MyPlantBabies_PlantParents_PlantParentId",
                table: "MyPlantBabies",
                column: "PlantParentId",
                principalTable: "PlantParents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
