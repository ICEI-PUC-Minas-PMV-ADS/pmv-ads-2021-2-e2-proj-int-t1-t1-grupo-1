using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaSaude.Migrations
{
    public partial class M99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Administradores_UsuarioId",
                table: "Receita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores");

            migrationBuilder.RenameTable(
                name: "Administradores",
                newName: "Administrador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administrador",
                table: "Administrador",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Farmacias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeFarmacia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmacias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Administrador_UsuarioId",
                table: "Receita",
                column: "UsuarioId",
                principalTable: "Administrador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Administrador_UsuarioId",
                table: "Receita");

            migrationBuilder.DropTable(
                name: "Farmacias");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administrador",
                table: "Administrador");

            migrationBuilder.RenameTable(
                name: "Administrador",
                newName: "Administradores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Administradores_UsuarioId",
                table: "Receita",
                column: "UsuarioId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
