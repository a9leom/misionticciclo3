using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalEnCasa.app.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                });

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
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familiar_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familiar_latitud = table.Column<int>(type: "int", nullable: true),
                    Familiar_longitud = table.Column<int>(type: "int", nullable: true),
                    nombre_hospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarjeta_profesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "SignoVitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pulso_cardiaco = table.Column<int>(type: "int", nullable: false),
                    presion = table.Column<int>(type: "int", nullable: false),
                    nivel_azucar = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignoVitales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anotaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pacienteId = table.Column<int>(type: "int", nullable: true),
                    medicoId = table.Column<int>(type: "int", nullable: true),
                    enfermeraId = table.Column<int>(type: "int", nullable: true),
                    signosVitalId = table.Column<int>(type: "int", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Personas_enfermeraId",
                        column: x => x.enfermeraId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Personas_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_Personas_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotaciones_SignoVitales_signosVitalId",
                        column: x => x.signosVitalId,
                        principalTable: "SignoVitales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_enfermeraId",
                table: "Anotaciones",
                column: "enfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_HistoriaId",
                table: "Anotaciones",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_medicoId",
                table: "Anotaciones",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_pacienteId",
                table: "Anotaciones",
                column: "pacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Anotaciones_signosVitalId",
                table: "Anotaciones",
                column: "signosVitalId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Personas_username",
                table: "Personas",
                column: "username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anotaciones");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "SignoVitales");
        }
    }
}
