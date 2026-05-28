using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase6.EF.Entidades.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaJuguete",
                columns: table => new
                {
                    CategoriasId = table.Column<int>(type: "int", nullable: false),
                    JuguetesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaJuguete", x => new { x.CategoriasId, x.JuguetesId });
                    table.ForeignKey(
                        name: "FK_CategoriaJuguete_Categoria_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaJuguete_Juguetes_JuguetesId",
                        column: x => x.JuguetesId,
                        principalTable: "Juguetes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaJuguete_JuguetesId",
                table: "CategoriaJuguete",
                column: "JuguetesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaJuguete");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
