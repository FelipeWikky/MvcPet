using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMvc.Data.Migrations
{
    public partial class CreateUserAndPetTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    petId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    species = table.Column<string>(nullable: true),
                    breed = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    donoruserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.petId);
                    table.ForeignKey(
                        name: "FK_Pets_Users_donoruserId",
                        column: x => x.donoruserId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_donoruserId",
                table: "Pets",
                column: "donoruserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
