using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaSaude.Data.Migrations
{
    public partial class M01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnotacoesNome",
                table: "Tratamentos",
                newName: "Anotacoes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Anotacoes",
                table: "Tratamentos",
                newName: "AnotacoesNome");
        }
    }
}
