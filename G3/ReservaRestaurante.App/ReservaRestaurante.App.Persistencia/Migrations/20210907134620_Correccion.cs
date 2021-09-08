using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservaRestaurante.App.Persistencia.Migrations
{
    public partial class Correccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_CLientes_clienteId",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CLientes",
                table: "CLientes");

            migrationBuilder.RenameTable(
                name: "CLientes",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_CLientes_cedula",
                table: "Clientes",
                newName: "IX_Clientes_cedula");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_clienteId",
                table: "Reservas",
                column: "clienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clienteId",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "CLientes");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_cedula",
                table: "CLientes",
                newName: "IX_CLientes_cedula");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CLientes",
                table: "CLientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_CLientes_clienteId",
                table: "Reservas",
                column: "clienteId",
                principalTable: "CLientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
