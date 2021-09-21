using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalEnCasa.app.Persistencia.Migrations
{
    public partial class Inicial2 : Migration
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
                    Enfermera_hospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    informacion_laboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familiar_Designado_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familiar_Designado_latitud = table.Column<int>(type: "int", nullable: true),
                    Familiar_Designado_longitud = table.Column<int>(type: "int", nullable: true),
                    tarjeta_profesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiempo_experiencia = table.Column<int>(type: "int", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<int>(type: "int", nullable: true),
                    longitud = table.Column<int>(type: "int", nullable: true),
                    medicoId = table.Column<int>(type: "int", nullable: true),
                    enfermeraId = table.Column<int>(type: "int", nullable: true),
                    familiarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_enfermeraId",
                        column: x => x.enfermeraId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_familiarId",
                        column: x => x.familiarId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "anotaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pacienteId = table.Column<int>(type: "int", nullable: true),
                    medicoId = table.Column<int>(type: "int", nullable: true),
                    enfermeraId = table.Column<int>(type: "int", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    formula_medica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anotaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anotaciones_Personas_enfermeraId",
                        column: x => x.enfermeraId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_anotaciones_Personas_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_anotaciones_Personas_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anotacionId = table.Column<int>(type: "int", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_historias_anotaciones_anotacionId",
                        column: x => x.anotacionId,
                        principalTable: "anotaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_anotaciones_enfermeraId",
                table: "anotaciones",
                column: "enfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_anotaciones_medicoId",
                table: "anotaciones",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_anotaciones_pacienteId",
                table: "anotaciones",
                column: "pacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_historias_anotacionId",
                table: "historias",
                column: "anotacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_cedula",
                table: "Personas",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_enfermeraId",
                table: "Personas",
                column: "enfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_familiarId",
                table: "Personas",
                column: "familiarId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_medicoId",
                table: "Personas",
                column: "medicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historias");

            migrationBuilder.DropTable(
                name: "anotaciones");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
