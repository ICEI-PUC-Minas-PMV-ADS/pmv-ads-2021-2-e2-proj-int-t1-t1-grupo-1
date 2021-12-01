using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaSaude.Migrations
{
    public partial class M10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeMedicamento",
                table: "CaixinhaDeRemedios");

            migrationBuilder.AddColumn<int>(
                name: "MedicamentoId",
                table: "CaixinhaDeRemedios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acesso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaixinhaDeRemedios_MedicamentoId",
                table: "CaixinhaDeRemedios",
                column: "MedicamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaixinhaDeRemedios_Medicamentos_MedicamentoId",
                table: "CaixinhaDeRemedios",
                column: "MedicamentoId",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaixinhaDeRemedios_Medicamentos_MedicamentoId",
                table: "CaixinhaDeRemedios");

            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropIndex(
                name: "IX_CaixinhaDeRemedios_MedicamentoId",
                table: "CaixinhaDeRemedios");

            migrationBuilder.DropColumn(
                name: "MedicamentoId",
                table: "CaixinhaDeRemedios");

            migrationBuilder.AddColumn<string>(
                name: "NomeMedicamento",
                table: "CaixinhaDeRemedios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
