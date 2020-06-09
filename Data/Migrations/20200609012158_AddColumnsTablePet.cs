using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMvc.Data.Migrations
{
    public partial class AddColumnsTablePet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropColumn(
            //     name: "phoneNumber",
            //     table: "Users");

            // migrationBuilder.RenameColumn(
            //     name: "PetId",
            //     table: "Pets",
            //     newName: "petId");

            // migrationBuilder.AddColumn<string>(
            //     name: "phone",
            //     table: "Users",
            //     nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Pets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uf",
                table: "Pets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropColumn(
            //     name: "phone",
            //     table: "Users");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "uf",
                table: "Pets");

            // migrationBuilder.RenameColumn(
            //     name: "petId",
            //     table: "Pets",
            //     newName: "PetId");

            // migrationBuilder.AddColumn<string>(
            //     name: "phoneNumber",
            //     table: "Users",
            //     type: "TEXT",
            //     nullable: true);
        }
    }
}
