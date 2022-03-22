using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDAO.Migrations
{
    public partial class Contacreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    nrConta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titularidPessoa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    saldoConta = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.nrConta);
                    table.ForeignKey(
                        name: "FK_Contas_Clientes_titularidPessoa",
                        column: x => x.titularidPessoa,
                        principalTable: "Clientes",
                        principalColumn: "idPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contas_titularidPessoa",
                table: "Contas",
                column: "titularidPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");
        }
    }
}
