using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Reservaciones",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHotel = table.Column<int>(type: "int", nullable: false),
                    IdHabitacion = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Ocupacion = table.Column<short>(type: "smallint", nullable: false),
                    NombreTomador = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservaciones", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Usuarios_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "TipoHabitacion",
                columns: table => new
                {
                    IdHotel = table.Column<int>(type: "int", nullable: false),
                    IdHabitacion = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    NumHabitaciones = table.Column<short>(type: "smallint", nullable: false),
                    ReservaIdReserva = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoHabitacion", x => new { x.IdHotel, x.IdHabitacion });
                    table.ForeignKey(
                        name: "FK_TipoHabitacion_Hotel_IdHotel",
                        column: x => x.IdHotel,
                        principalTable: "Hotel",
                        principalColumn: "IdHotel",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoHabitacion_Reservaciones_ReservaIdReserva",
                        column: x => x.ReservaIdReserva,
                        principalTable: "Reservaciones",
                        principalColumn: "IdReserva");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones",
                columns: new[] { "TipoHabitacionIdHotel", "TipoHabitacionIdHabitacion" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_ClientId",
                table: "Reservaciones",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoHabitacion_ReservaIdReserva",
                table: "TipoHabitacion",
                column: "ReservaIdReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_TipoHabitacion_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones",
                columns: new[] { "TipoHabitacionIdHotel", "TipoHabitacionIdHabitacion" },
                principalTable: "TipoHabitacion",
                principalColumns: new[] { "IdHotel", "IdHabitacion" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_TipoHabitacion_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropTable(
                name: "TipoHabitacion");

            migrationBuilder.DropTable(
                name: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_TipoHabitacionIdHotel_TipoHabitacionIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "TipoHabitacionIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "TipoHabitacionIdHotel",
                table: "Habitaciones");
        }
    }
}
