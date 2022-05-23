using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Actualizando_Nombres_Campos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categorias",
                newName: "CategoriaNombre");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Administradores",
                newName: "NombreAdministrador");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaInicio",
                table: "Reservaciones",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFin",
                table: "Reservaciones",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoriaNombre",
                table: "Categorias",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NombreAdministrador",
                table: "Administradores",
                newName: "Nombre");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaInicio",
                table: "Reservaciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFin",
                table: "Reservaciones",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
