using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCantina.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeAdministrador = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoAdministrador = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CpfUsuario = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCategoria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescricaoCategoria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagemCategoria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "colaboradores",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeColaborador = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoColaborador = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CpfUsuario = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colaboradores", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "comuns",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CpfUsuario = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comuns", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comandas",
                columns: table => new
                {
                    IdCarrinho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ValorTotal = table.Column<double>(type: "double", nullable: false),
                    ClienteIdUsuario = table.Column<int>(type: "int", nullable: false),
                    VendedorIdUsuario = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.IdCarrinho);
                    table.ForeignKey(
                        name: "FK_Comandas_colaboradores_VendedorIdUsuario",
                        column: x => x.VendedorIdUsuario,
                        principalTable: "colaboradores",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comandas_comuns_ClienteIdUsuario",
                        column: x => x.ClienteIdUsuario,
                        principalTable: "comuns",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeProduto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescricaoProduto = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaProdutoIdCategoria = table.Column<int>(type: "int", nullable: false),
                    QuantidadeEstoque = table.Column<int>(type: "int", nullable: false),
                    PrecoVenda = table.Column<double>(type: "double", nullable: false),
                    PrecoCusto = table.Column<double>(type: "double", nullable: false),
                    Imagem = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false),
                    CarrinhoIdCarrinho = table.Column<int>(type: "int", nullable: true),
                    ComumIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaProdutoIdCategoria",
                        column: x => x.CategoriaProdutoIdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Comandas_CarrinhoIdCarrinho",
                        column: x => x.CarrinhoIdCarrinho,
                        principalTable: "Comandas",
                        principalColumn: "IdCarrinho");
                    table.ForeignKey(
                        name: "FK_Produtos_comuns_ComumIdUsuario",
                        column: x => x.ComumIdUsuario,
                        principalTable: "comuns",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_ClienteIdUsuario",
                table: "Comandas",
                column: "ClienteIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_VendedorIdUsuario",
                table: "Comandas",
                column: "VendedorIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CarrinhoIdCarrinho",
                table: "Produtos",
                column: "CarrinhoIdCarrinho");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaProdutoIdCategoria",
                table: "Produtos",
                column: "CategoriaProdutoIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ComumIdUsuario",
                table: "Produtos",
                column: "ComumIdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Comandas");

            migrationBuilder.DropTable(
                name: "colaboradores");

            migrationBuilder.DropTable(
                name: "comuns");
        }
    }
}
