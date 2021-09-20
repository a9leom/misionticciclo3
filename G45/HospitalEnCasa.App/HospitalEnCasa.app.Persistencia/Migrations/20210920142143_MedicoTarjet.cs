using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalEnCasa.app.Persistencia.Migrations
{
    public partial class MedicoTarjet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cedula = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre_hospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarjeta_profesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<int>(type: "int", nullable: true),
                    longitud = table.Column<int>(type: "int", nullable: true),
                    medico_asignadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_medico_asignadoId",
                        column: x => x.medico_asignadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_cedula",
                table: "Personas",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_medico_asignadoId",
                table: "Personas",
                column: "medico_asignadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
