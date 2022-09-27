using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiHouse.App.Persistencia.Migrations
{
    public partial class AgregarAtributoContraseña : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "contraseña",
                table: "pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contraseña",
                table: "auxiliares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contraseña",
                table: "pacientes");

            migrationBuilder.DropColumn(
                name: "contraseña",
                table: "auxiliares");
        }
    }
}
