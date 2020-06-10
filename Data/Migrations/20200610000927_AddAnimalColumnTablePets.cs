using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMvc.Data.Migrations
{
    public partial class AddAnimalColumnTablePets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "animalid",
                table: "Pets",
                nullable: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_Pets_animalid",
            //     table: "Pets",
            //     column: "animalid");

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Pets_Animals_animalid",
            //     table: "Pets",
            //     column: "animalid",
            //     principalTable: "Animals",
            //     principalColumn: "id",
            //     onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Pets_Animals_animalid",
            //     table: "Pets");

            // migrationBuilder.DropIndex(
            //     name: "IX_Pets_animalid",
            //     table: "Pets");

            migrationBuilder.DropColumn(
                name: "animalid",
                table: "Pets");
        }
    }
}
