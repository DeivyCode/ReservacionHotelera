using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Actualizando_ForeingKeys_Reserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_Usuarios_ClientId",
                table: "Reservaciones");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_Usuarios_ClientId",
                table: "Reservaciones",
                column: "ClientId",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_Usuarios_ClientId",
                table: "Reservaciones");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Reservaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_Usuarios_ClientId",
                table: "Reservaciones",
                column: "ClientId",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario");
        }
    }
}
