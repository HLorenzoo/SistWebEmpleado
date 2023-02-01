using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistWebEmpleado.Migrations
{
    public partial class hernu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    DNI = table.Column<string>(nullable: true),
                    Legajo = table.Column<string>(type: "varchar(50)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Título = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
