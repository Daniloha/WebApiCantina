using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCantina.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Inserindo dados para a tabela Produto e associando à categoria
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "IdProduto", "NomeProduto", "DescricaoProduto", "IdCategoria", "QuantidadeEstoque", "PrecoVenda", "PrecoCusto", "Imagem", "DataCriacao" },
values: new object[,]
{
    { 1, "Refrigerante Lata 350ml", "Refrigerante gelado de 350ml.", 1, 50, 5.00, 3.00, "https://example.com/images/refrigerante.jpg", new DateOnly(2025, 5, 16) },
    { 2, "Coxinha de Frango", "Coxinha de frango crocante e saborosa.", 2, 30, 4.00, 2.00, "https://example.com/images/coxinha.jpg", new DateOnly(2025, 5, 16) },
    { 3, "Suco de laranja 250ml", "Suco de laranja 250ml.", 1, 30, 6.00, 4.00, "https://example.com/images/suco.jpg", new DateOnly(2025, 5, 16) },
    { 4, "Pastel de Frango", "Pastel de frango recheado com catupiry.", 2, 20, 7.00, 5.00, "https://example.com/images/pastel.jpg", new DateOnly(2025, 5, 16) },
    { 5, "Cafe Americano 250ml", "Cafe Americano 250ml.", 5, 40, 8.00, 6.00, "https://example.com/images/cafe.jpg", new DateOnly(2025, 5, 16) },
    { 6, "Cappuccino 250ml", "Cappuccino 250ml.", 5, 40, 9.00, 7.00, "https://example.com/images/cappuccino.jpg", new DateOnly(2025, 5, 16) },
    { 7, "Bolo de Chocolate", "Bolo de chocolate recheado com morango.", 3, 30, 10.00, 8.00, "https://example.com/images/bolo.jpg", new DateOnly(2025, 5, 16) },
    { 8, "Brigadeiro", "Brigadeiro.", 4, 30, 11.00, 9.00, "https://example.com/images/brigadeiro.jpg", new DateOnly(2025, 5, 16) },
    { 9, "Torta de Chocolate", "Torta de chocolate recheada com chocolate.", 4, 30, 12.00, 10.00, "https://example.com/images/torta.jpg", new DateOnly(2025, 5, 16) },
    {10, "Coca-cola zero", "Coca-cola zero.", 1, 30, 13.00, 11.00, "https://example.com/images/coca-cola.jpg", new DateOnly(2025, 5, 16) },
    {11, "Pão de queijo", "Pão de queijo.", 4, 30, 14.00, 12.00, "https://example.com/images/pao.jpg", new DateOnly(2025, 5, 16) },
    {12, "Esfirra de carne", "Esfirra de carne.", 2, 30, 15.00, 13.00, "https://example.com/images/esfirra.jpg", new DateOnly(2025, 5, 16) }
}
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remover os dados inseridos se a migration for revertida
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "IdProduto",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }
            );
        }
    }
}
