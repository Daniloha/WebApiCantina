using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCantina.Migrations
{
    /// <inheritdoc />
    public partial class FixPrecoCusto1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaProdutoIdCategoria",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoriaProdutoIdCategoria",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CategoriaProdutoIdCategoria",
                table: "Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdCategoria",
                table: "Produtos",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_IdCategoria",
                table: "Produtos",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_IdCategoria",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_IdCategoria",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaProdutoIdCategoria",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaProdutoIdCategoria",
                table: "Produtos",
                column: "CategoriaProdutoIdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaProdutoIdCategoria",
                table: "Produtos",
                column: "CategoriaProdutoIdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
