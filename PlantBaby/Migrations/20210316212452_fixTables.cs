using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantBaby.Migrations
{
    public partial class fixTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantParents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantParents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Light = table.Column<string>(nullable: true),
                    Water = table.Column<int>(nullable: false),
                    SoilType = table.Column<string>(nullable: true),
                    PlantParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantTypes_PlantParents_PlantParentId",
                        column: x => x.PlantParentId,
                        principalTable: "PlantParents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MyPlantBabies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    DatePlanted = table.Column<DateTime>(nullable: false),
                    LastWatered = table.Column<DateTime>(nullable: false),
                    PlantParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlantBabies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyPlantBabies_PlantParents_PlantParentId",
                        column: x => x.PlantParentId,
                        principalTable: "PlantParents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyPlantBabies_PlantTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "PlantTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyPlantBabies_PlantParentId",
                table: "MyPlantBabies",
                column: "PlantParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MyPlantBabies_TypeId",
                table: "MyPlantBabies",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantTypes_PlantParentId",
                table: "PlantTypes",
                column: "PlantParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyPlantBabies");

            migrationBuilder.DropTable(
                name: "PlantTypes");

            migrationBuilder.DropTable(
                name: "PlantParents");
        }
    }
}
