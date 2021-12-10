using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaSaude.Migrations
{
    public partial class M14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Acesso",
                table: "Administrador",
                newName: "Perfil");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Administrador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeFarmacia",
                table: "Administrador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Administrador");

            migrationBuilder.DropColumn(
                name: "NomeFarmacia",
                table: "Administrador");

            migrationBuilder.RenameColumn(
                name: "Perfil",
                table: "Administrador",
                newName: "Acesso");
        }
    }
}
