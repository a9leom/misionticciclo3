using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservaRestaurante.App.Persistencia.Migrations
{
    public partial class Cambio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Mesas_numero",
                table: "Mesas",
                column: "numero",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mesas_numero",
                table: "Mesas");
        }
    }
}
