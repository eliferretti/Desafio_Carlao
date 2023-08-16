using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.Persistence.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Enderecos");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_IdPessoa",
                table: "Telefones",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_IdPessoa",
                table: "Enderecos",
                column: "IdPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_IdPessoa",
                table: "Enderecos",
                column: "IdPessoa",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_IdPessoa",
                table: "Telefones",
                column: "IdPessoa",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_IdPessoa",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_IdPessoa",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_IdPessoa",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_IdPessoa",
                table: "Enderecos");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Telefones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Enderecos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
