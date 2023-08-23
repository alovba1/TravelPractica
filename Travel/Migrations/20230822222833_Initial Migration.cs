using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atencion.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodAsegurador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodMpioResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoVital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPersona = table.Column<int>(type: "int", nullable: false),
                    FechaDefuncion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UbicacionDefuncion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodLugarAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAtencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PesoKg = table.Column<int>(type: "int", nullable: false),
                    CodClasificacionNutricional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TallaCm = table.Column<int>(type: "int", nullable: false),
                    CodManejoActual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesManejo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodUbicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesUbicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodTratamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSobreFTLC = table.Column<int>(type: "int", nullable: false),
                    OtroTratamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguimiento", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Seguimiento");
        }
    }
}
