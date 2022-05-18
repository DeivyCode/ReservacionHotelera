using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Actualizando_Model_Habitacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_TipoHabitacion_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitacion_Hotel_IdHotel",
                table: "TipoHabitacion");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHabitacion",
                table: "TipoHabitacion");

            migrationBuilder.DropIndex(
                name: "IX_TipoHabitacion_IdHabitacion",
                table: "TipoHabitacion");

            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "TipoHabitacionIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "TipoHabitacionIdHotel",
                table: "Habitaciones");

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
                name: "TipoHabitacionIdHabitacion",
                table: "Habitaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoHabitacionIdHotel",
                table: "Habitaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoHabitacion_IdHabitacion",
                table: "TipoHabitacion",
                column: "IdHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones",
                columns: new[] { "TipoHabitacionIdHotel", "TipoHabitacionIdHabitacion" });

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_TipoHabitacion_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones",
                columns: new[] { "TipoHabitacionIdHotel", "TipoHabitacionIdHabitacion" },
                principalTable: "TipoHabitacion",
                principalColumns: new[] { "IdHotel", "IdHabitacion" });

            migrationBuilder.AddForeignKey(
                name: "FK_TipoHabitacion_Hotel_IdHotel",
                table: "TipoHabitacion",
                column: "IdHotel",
                principalTable: "Hotel",
                principalColumn: "IdHotel",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHabitacion",
                table: "TipoHabitacion",
                column: "IdHabitacion",
                principalTable: "Reservaciones",
                principalColumn: "IdReserva",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
