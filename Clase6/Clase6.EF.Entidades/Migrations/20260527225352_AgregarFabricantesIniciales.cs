using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clase6.EF.Entidades.Migrations
{
    /// <inheritdoc />
    public partial class AgregarFabricantesIniciales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fabricantes",
                columns: new[] { "Id", "Nombre", "Pais" },
                values: new object[,]
                {
                    { 1, "LEGO", "Dinamarca" },
                    { 2, "Hasbro", "Estados Unidos" },
                    { 3, "Mattel", "Estados Unidos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fabricantes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fabricantes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fabricantes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
