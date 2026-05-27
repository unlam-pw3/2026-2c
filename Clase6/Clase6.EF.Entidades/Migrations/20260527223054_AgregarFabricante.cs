using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase6.EF.Entidades.Migrations
{
    /// <inheritdoc />
    public partial class AgregarFabricante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FabricanteId",
                table: "Juguetes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fabricantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricantes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Juguetes_FabricanteId",
                table: "Juguetes",
                column: "FabricanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Juguetes_Fabricantes_FabricanteId",
                table: "Juguetes",
                column: "FabricanteId",
                principalTable: "Fabricantes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juguetes_Fabricantes_FabricanteId",
                table: "Juguetes");

            migrationBuilder.DropTable(
                name: "Fabricantes");

            migrationBuilder.DropIndex(
                name: "IX_Juguetes_FabricanteId",
                table: "Juguetes");

            migrationBuilder.DropColumn(
                name: "FabricanteId",
                table: "Juguetes");
        }
    }
}
