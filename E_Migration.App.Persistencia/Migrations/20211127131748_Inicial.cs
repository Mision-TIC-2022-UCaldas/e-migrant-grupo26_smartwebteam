using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Migration.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais_Origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo_Electronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Telefonico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion_Actual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situacion_Laboral = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Migrantes");
        }
    }
}
