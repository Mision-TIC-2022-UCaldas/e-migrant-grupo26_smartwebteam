using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Migration.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razon_Social = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Nit = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pagina_Web = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Tipo_Servicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calificacion = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Tipo_Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Identificacion = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Pais_Origen = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo_Electronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Telefonico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_Actual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacion_Laboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Necesidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Necesidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Clasificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Identificacion_Migrante = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necesidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Novedad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    Explicacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisGoogle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisGoogle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Ser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_In_Oferta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_fn_Oferta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Entidad = table.Column<int>(type: "int", nullable: false),
                    Calificacion = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entidades");

            migrationBuilder.DropTable(
                name: "Migrantes");

            migrationBuilder.DropTable(
                name: "Necesidades");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "RegisGoogle");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
