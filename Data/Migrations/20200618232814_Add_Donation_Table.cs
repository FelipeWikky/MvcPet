using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMvc.Data.Migrations
{
    public partial class Add_Donation_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterColumn<string>(
            //     name: "uf",
            //     table: "Pets",
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldType: "TEXT",
            //     oldNullable: true);

            // migrationBuilder.AlterColumn<string>(
            //     name: "species",
            //     table: "Pets",
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldType: "TEXT",
            //     oldNullable: true);

            // migrationBuilder.AlterColumn<string>(
            //     name: "image",
            //     table: "Pets",
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldType: "TEXT",
            //     oldNullable: true);

            // migrationBuilder.AlterColumn<string>(
            //     name: "city",
            //     table: "Pets",
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldType: "TEXT",
            //     oldNullable: true);

            // migrationBuilder.AlterColumn<string>(
            //     name: "breed",
            //     table: "Pets",
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldType: "TEXT",
            //     oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    doadoruserId = table.Column<string>(nullable: true),
                    doacaopetId = table.Column<int>(nullable: true),
                    donatariouserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_Pets_doacaopetId",
                        column: x => x.doacaopetId,
                        principalTable: "Pets",
                        principalColumn: "petId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_Users_doadoruserId",
                        column: x => x.doadoruserId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_Users_donatariouserId",
                        column: x => x.donatariouserId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donations_doacaopetId",
                table: "Donations",
                column: "doacaopetId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_doadoruserId",
                table: "Donations",
                column: "doadoruserId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_donatariouserId",
                table: "Donations",
                column: "donatariouserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donations");

            // migrationBuilder.AlterColumn<string>(
            //     name: "uf",
            //     table: "Pets",
            //     type: "TEXT",
            //     nullable: true,
            //     oldClrType: typeof(string));

            // migrationBuilder.AlterColumn<string>(
            //     name: "species",
            //     table: "Pets",
            //     type: "TEXT",
            //     nullable: true,
            //     oldClrType: typeof(string));

            // migrationBuilder.AlterColumn<string>(
            //     name: "image",
            //     table: "Pets",
            //     type: "TEXT",
            //     nullable: true,
            //     oldClrType: typeof(string));

            // migrationBuilder.AlterColumn<string>(
            //     name: "city",
            //     table: "Pets",
            //     type: "TEXT",
            //     nullable: true,
            //     oldClrType: typeof(string));

            // migrationBuilder.AlterColumn<string>(
            //     name: "breed",
            //     table: "Pets",
            //     type: "TEXT",
            //     nullable: true,
            //     oldClrType: typeof(string));
        }
    }
}
