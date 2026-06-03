using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clase6.EF.Entidades.Migrations
{
    /// <inheritdoc />
    public partial class AgregarSucursales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "Id", "Altura", "Calle", "Nombre" },
                values: new object[,]
                {
                    { 1, "1234", "Corrientes", "Sucursal Centro" },
                    { 2, "4567", "Santa Fe", "Sucursal Palermo" },
                    { 3, "890", "Cabildo", "Sucursal Belgrano" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sucursales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sucursales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sucursales",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
