using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Agregando_Categoria_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Hotel");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Hotel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CategoriaId",
                table: "Hotel",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Categorias_CategoriaId",
                table: "Hotel",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Categorias_CategoriaId",
                table: "Hotel");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_CategoriaId",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Hotel");

            migrationBuilder.AddColumn<short>(
                name: "Categoria",
                table: "Hotel",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
