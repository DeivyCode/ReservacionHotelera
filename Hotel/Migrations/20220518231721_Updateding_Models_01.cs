using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Updateding_Models_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitacion_Reservaciones_IdHotel",
                table: "TipoHabitacion");

            migrationBuilder.AlterColumn<int>(
                name: "IdHotel",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "IdHabitacion",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "IdReserva",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_IdHotel_IdHabitacion",
                table: "Reservaciones",
                columns: new[] { "IdHotel", "IdHabitacion" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_TipoHabitacion_IdHotel_IdHabitacion",
                table: "Reservaciones",
                columns: new[] { "IdHotel", "IdHabitacion" },
                principalTable: "TipoHabitacion",
                principalColumns: new[] { "IdHotel", "IdHabitacion" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_TipoHabitacion_IdHotel_IdHabitacion",
                table: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reservaciones_IdHotel_IdHabitacion",
                table: "Reservaciones");

            migrationBuilder.AlterColumn<int>(
                name: "IdHotel",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "IdHabitacion",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "IdReserva",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
