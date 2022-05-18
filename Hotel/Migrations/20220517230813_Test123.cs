using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Test123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_ReservaIdReserva",
                table: "TipoHabitacion");

            migrationBuilder.DropIndex(
                name: "IX_TipoHabitacion_ReservaIdReserva",
                table: "TipoHabitacion");

            migrationBuilder.DropColumn(
                name: "ReservaIdReserva",
                table: "TipoHabitacion");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHotel",
                table: "TipoHabitacion",
                column: "IdHotel",
                principalTable: "Reservaciones",
                principalColumn: "IdReserva",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHotel",
                table: "TipoHabitacion");

            migrationBuilder.AddColumn<int>(
                name: "ReservaIdReserva",
                table: "TipoHabitacion",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoHabitacion_ReservaIdReserva",
                table: "TipoHabitacion",
                column: "ReservaIdReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_ReservaIdReserva",
                table: "TipoHabitacion",
                column: "ReservaIdReserva",
                principalTable: "Reservaciones",
                principalColumn: "IdReserva");
        }
    }
}
