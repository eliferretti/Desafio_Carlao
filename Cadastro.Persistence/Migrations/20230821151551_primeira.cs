using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.Persistence.Migrations
{
    public partial class primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<int>(type: "INTEGER", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    RG = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true),
                    EstadoCivil = table.Column<int>(type: "INTEGER", nullable: false),
                    Profissao = table.Column<string>(type: "TEXT", nullable: true),
                    Nacionalidade = table.Column<string>(type: "TEXT", nullable: true),
                    Naturalidade = table.Column<string>(type: "TEXT", nullable: true),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPessoa = table.Column<int>(type: "INTEGER", nullable: false),
                    Rua = table.Column<string>(type: "TEXT", nullable: true),
                    Numero = table.Column<string>(type: "TEXT", nullable: true),
                    Complemento = table.Column<string>(type: "TEXT", nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", nullable: true),
                    Cidade = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    CEP = table.Column<string>(type: "TEXT", nullable: true),
                    Pais = table.Column<string>(type: "TEXT", nullable: true),
                    Referencia = table.Column<string>(type: "TEXT", nullable: true),
                    PontoReferencia = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPessoa = table.Column<int>(type: "INTEGER", nullable: false),
                    DDD = table.Column<string>(type: "TEXT", nullable: true),
                    Numero = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_IdPessoa",
                table: "Enderecos",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_IdPessoa",
                table: "Telefones",
                column: "IdPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
