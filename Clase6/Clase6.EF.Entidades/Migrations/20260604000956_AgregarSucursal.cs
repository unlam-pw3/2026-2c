using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clase6.EF.Entidades.Migrations
{
    /// <inheritdoc />
    public partial class AgregarSucursal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SucursalId",
                table: "Juguetes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "Id", "Altura", "Calle", "Nombre" },
                values: new object[,]
                {
                    { 1, "1234", "Corrientes", "Sucursal Centro" },
                    { 2, "4567", "Santa Fe", "Sucursal Palermo" },
                    { 3, "890", "Cabildo", "Sucursal Belgrano" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Juguetes_SucursalId",
                table: "Juguetes",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Juguetes_Sucursales_SucursalId",
                table: "Juguetes",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juguetes_Sucursales_SucursalId",
                table: "Juguetes");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropIndex(
                name: "IX_Juguetes_SucursalId",
                table: "Juguetes");

            migrationBuilder.DropColumn(
                name: "SucursalId",
                table: "Juguetes");
        }
    }
}
