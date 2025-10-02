using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCantina.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Inserindo dados para a tabela Categoria
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategoria", "NomeCategoria", "DescricaoCategoria", "ImagemCategoria", "DataCriacao" },
                values: new object[,]
{
    { 1, "Bebidas geladas", "Categoria para refrigerantes, sucos e outras bebidas.", "https://example.com/images/bebidas.jpg", new DateOnly(2025, 5, 16) },
    { 2, "Salgados", "Categoria para salgados como coxinhas, pastéis, etc.", "https://example.com/images/salgados.jpg", new DateOnly(2025, 5, 16) },
    { 3, "Sobremesas", "Categorias para sobremesas.", "https://example.com/images/sobremesas.jpg", new DateOnly(2025, 5, 16) },
    { 4, "Doces", "Categorias para doces.", "https://example.com/images/doces.jpg", new DateOnly(2025, 5, 16) },
    { 5, "Cafés", "Categorias para cafés", "https://example.com/images/cafes.jpg", new DateOnly(2025, 5, 16) }
}
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remover os dados inseridos se a migration for revertida

            migrationBuilder.DeleteData(
            table: "Categorias",
            keyColumn: "IdCategoria",
            keyValues: new object[] { 1, 2, 3, 4, 5 }
);
        }
    }
}
