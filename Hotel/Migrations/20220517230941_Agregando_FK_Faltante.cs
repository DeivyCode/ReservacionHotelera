using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Agregando_FK_Faltante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHotel",
                table: "TipoHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_TipoHabitacion_IdHabitacion",
                table: "TipoHabitacion",
                column: "IdHabitacion");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHabitacion",
                table: "TipoHabitacion",
                column: "IdHabitacion",
                principalTable: "Reservaciones",
                principalColumn: "IdReserva",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHabitacion",
                table: "TipoHabitacion");

            migrationBuilder.DropIndex(
                name: "IX_TipoHabitacion_IdHabitacion",
                table: "TipoHabitacion");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHotel",
                table: "TipoHabitacion",
                column: "IdHotel",
                principalTable: "Reservaciones",
                principalColumn: "IdReserva",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
