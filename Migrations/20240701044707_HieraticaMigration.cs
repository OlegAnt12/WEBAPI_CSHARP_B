using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hieratica.Migrations
{
    /// <inheritdoc />
    public partial class HieraticaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BilheteIdentidade = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NIS = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DenominacaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designacao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DenominacaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telelefone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empresa = table.Column<int>(type: "int", nullable: false),
                    venda = table.Column<int>(type: "int", nullable: false),
                    montanteDeImposto = table.Column<decimal>(type: "Decimal(13,2)", nullable: false),
                    motivoDeNaoLiquidacaoDoImposto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designacao = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    preco = table.Column<decimal>(type: "Decimal(13,2)", nullable: false),
                    taxaDeImposto = table.Column<decimal>(type: "Decimal(13,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Utilizador",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Telelefone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BilheteIdentidade = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estadoConta = table.Column<int>(type: "int", nullable: false),
                    perfil = table.Column<int>(type: "int", nullable: false),
                    empresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizador", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente = table.Column<int>(type: "int", nullable: false),
                    produto = table.Column<int>(type: "int", nullable: false),
                    QuantidadeVendida = table.Column<int>(type: "int", nullable: false),
                    totalAPagar = table.Column<decimal>(type: "Decimal(13,2)", nullable: false),
                    valorPago = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    troco = table.Column<decimal>(type: "Decimal(13,2)", nullable: false),
                    dataVenda = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.VendaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_BilheteIdentidade",
                table: "Cliente",
                column: "BilheteIdentidade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_NIF",
                table: "Cliente",
                column: "NIF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_NIS",
                table: "Cliente",
                column: "NIS",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_Designacao",
                table: "Empresa",
                column: "Designacao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_NIF",
                table: "Empresa",
                column: "NIF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_Telelefone",
                table: "Empresa",
                column: "Telelefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Designacao",
                table: "Produto",
                column: "Designacao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_BilheteIdentidade",
                table: "Utilizador",
                column: "BilheteIdentidade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_Email",
                table: "Utilizador",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_Telelefone",
                table: "Utilizador",
                column: "Telelefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_Username",
                table: "Utilizador",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Utilizador");

            migrationBuilder.DropTable(
                name: "Venda");
        }
    }
}
