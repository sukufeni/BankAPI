using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankDAO.Migrations
{
    public partial class EntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_titularidPessoa",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Contas_titularidPessoa",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "titularidPessoa",
                table: "Contas");

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteidPessoa",
                table: "Contas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "titular",
                table: "Contas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contas_ClienteidPessoa",
                table: "Contas",
                column: "ClienteidPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteidPessoa",
                table: "Contas",
                column: "ClienteidPessoa",
                principalTable: "Clientes",
                principalColumn: "idPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteidPessoa",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Contas_ClienteidPessoa",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "ClienteidPessoa",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "titular",
                table: "Contas");

            migrationBuilder.AddColumn<Guid>(
                name: "titularidPessoa",
                table: "Contas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Contas_titularidPessoa",
                table: "Contas",
                column: "titularidPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_titularidPessoa",
                table: "Contas",
                column: "titularidPessoa",
                principalTable: "Clientes",
                principalColumn: "idPessoa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
