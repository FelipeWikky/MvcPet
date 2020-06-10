using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMvc.Data.Migrations
{
    public partial class CreateUFTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Pets_Animals_animalid",
            //     table: "Pets");

            // migrationBuilder.AlterColumn<int>(
            //     name: "animalid",
            //     table: "Pets",
            //     nullable: false,
            //     oldClrType: typeof(int),
            //     oldType: "INTEGER",
            //     oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Ufs",
                columns: table => new
                {
                    sigla = table.Column<string>(nullable: false),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ufs", x => x.sigla);
                });

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Pets_Animals_animalid",
            //     table: "Pets",
            //     column: "animalid",
            //     principalTable: "Animals",
            //     principalColumn: "id",
            //     onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Pets_Animals_animalid",
            //     table: "Pets");

            migrationBuilder.DropTable(
                name: "Ufs");

            // migrationBuilder.AlterColumn<int>(
            //     name: "animalid",
            //     table: "Pets",
            //     type: "INTEGER",
            //     nullable: true,
            //     oldClrType: typeof(int));

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Pets_Animals_animalid",
            //     table: "Pets",
            //     column: "animalid",
            //     principalTable: "Animals",
            //     principalColumn: "id",
            //     onDelete: ReferentialAction.Restrict);
        }
    }
}
