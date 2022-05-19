using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Actualizando_ForeingKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Administradores_IdAdministrador",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Categorias_CategoriaId",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_CategoriaId",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Hotel");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Hotel",
                newName: "IdCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_Hotel_IdAdministrador",
                table: "Hotel",
                newName: "IX_Hotel_IdCategoria");

            migrationBuilder.AddColumn<int>(
                name: "IdAdministrador",
                table: "Hotel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_IdAdministrador",
                table: "Hotel",
                column: "IdAdministrador");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Administradores_IdAdministrador",
                table: "Hotel",
                column: "IdAdministrador",
                principalTable: "Administradores",
                principalColumn: "IdAdministrador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Categorias_IdCategoria",
                table: "Hotel",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Administradores_IdAdministrador",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Categorias_IdCategoria",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_IdAdministrador",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "IdAdministrador",
                table: "Hotel");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Hotel",
                newName: "AdministradorIdIdAdministrador");

            migrationBuilder.RenameIndex(
                name: "IX_Hotel_IdCategoria",
                table: "Hotel",
                newName: "IX_Hotel_AdministradorIdIdAdministrador");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Hotel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CategoriaId",
                table: "Hotel",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Administradores_AdministradorIdIdAdministrador",
                table: "Hotel",
                column: "AdministradorIdIdAdministrador",
                principalTable: "Administradores",
                principalColumn: "IdAdministrador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Categorias_CategoriaId",
                table: "Hotel",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }
    }
}
