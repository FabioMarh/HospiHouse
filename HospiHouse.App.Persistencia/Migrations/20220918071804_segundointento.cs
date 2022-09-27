using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiHouse.App.Persistencia.Migrations
{
    public partial class segundointento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "auxiliares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idAuxiliar = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auxiliares", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "enfermeras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    targetaProfecional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horasLaboralesSemana = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enfermeras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "medicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registroReTHUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "familiares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    TipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    correoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentescoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idPaciente = table.Column<int>(type: "int", nullable: false),
                    pacienteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_familiares", x => x.id);
                    table.ForeignKey(
                        name: "FK_familiares_pacientes_pacienteid",
                        column: x => x.pacienteid,
                        principalTable: "pacientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historiasMedicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idHistoriaMedica = table.Column<int>(type: "int", nullable: false),
                    diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entornoHospitalizacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idPaciente = table.Column<int>(type: "int", nullable: false),
                    pacienteid = table.Column<int>(type: "int", nullable: false),
                    idMedico = table.Column<int>(type: "int", nullable: false),
                    medicoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historiasMedicas", x => x.id);
                    table.ForeignKey(
                        name: "FK_historiasMedicas_medicos_medicoid",
                        column: x => x.medicoid,
                        principalTable: "medicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historiasMedicas_pacientes_pacienteid",
                        column: x => x.pacienteid,
                        principalTable: "pacientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "signosVitales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadoGeneral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaYHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    oximetria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frecuenciaRespiratoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frecuenciaCardiaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precionArterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idEnfermera = table.Column<int>(type: "int", nullable: false),
                    enfermeraid = table.Column<int>(type: "int", nullable: false),
                    idHistoriaMedica = table.Column<int>(type: "int", nullable: false),
                    historiaMedicaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signosVitales", x => x.id);
                    table.ForeignKey(
                        name: "FK_signosVitales_enfermeras_enfermeraid",
                        column: x => x.enfermeraid,
                        principalTable: "enfermeras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_signosVitales_historiasMedicas_historiaMedicaid",
                        column: x => x.historiaMedicaid,
                        principalTable: "historiasMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sugerenciasCuidado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sugerencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idHistoriaMedica = table.Column<int>(type: "int", nullable: false),
                    historiaMedicaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sugerenciasCuidado", x => x.id);
                    table.ForeignKey(
                        name: "FK_sugerenciasCuidado_historiasMedicas_historiaMedicaid",
                        column: x => x.historiaMedicaid,
                        principalTable: "historiasMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_familiares_pacienteid",
                table: "familiares",
                column: "pacienteid");

            migrationBuilder.CreateIndex(
                name: "IX_historiasMedicas_medicoid",
                table: "historiasMedicas",
                column: "medicoid");

            migrationBuilder.CreateIndex(
                name: "IX_historiasMedicas_pacienteid",
                table: "historiasMedicas",
                column: "pacienteid");

            migrationBuilder.CreateIndex(
                name: "IX_signosVitales_enfermeraid",
                table: "signosVitales",
                column: "enfermeraid");

            migrationBuilder.CreateIndex(
                name: "IX_signosVitales_historiaMedicaid",
                table: "signosVitales",
                column: "historiaMedicaid");

            migrationBuilder.CreateIndex(
                name: "IX_sugerenciasCuidado_historiaMedicaid",
                table: "sugerenciasCuidado",
                column: "historiaMedicaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "auxiliares");

            migrationBuilder.DropTable(
                name: "familiares");

            migrationBuilder.DropTable(
                name: "signosVitales");

            migrationBuilder.DropTable(
                name: "sugerenciasCuidado");

            migrationBuilder.DropTable(
                name: "enfermeras");

            migrationBuilder.DropTable(
                name: "historiasMedicas");

            migrationBuilder.DropTable(
                name: "medicos");

            migrationBuilder.DropTable(
                name: "pacientes");
        }
    }
}
