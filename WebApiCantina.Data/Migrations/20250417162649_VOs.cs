using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCantina.Migrations
{
    /// <inheritdoc />
    public partial class VOs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_comuns_ComumIdUsuario",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ComumIdUsuario",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ComumIdUsuario",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CpfUsuario",
                table: "comuns");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "comuns");

            migrationBuilder.DropColumn(
                name: "CpfUsuario",
                table: "colaboradores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "colaboradores");

            migrationBuilder.DropColumn(
                name: "CpfUsuario",
                table: "administradores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "administradores");

            migrationBuilder.RenameColumn(
                name: "PrecoVenda",
                table: "Produtos",
                newName: "PrecoVenda_Valor");

            migrationBuilder.RenameColumn(
                name: "PrecoCusto",
                table: "Produtos",
                newName: "PrecoCusto_Valor");

            migrationBuilder.RenameColumn(
                name: "Imagem",
                table: "Produtos",
                newName: "Imagem_Url");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "comuns",
                newName: "Telefone_Numero");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Comandas",
                newName: "ValorTotal_Valor");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "colaboradores",
                newName: "Telefone_Numero");

            migrationBuilder.RenameColumn(
                name: "ImagemCategoria",
                table: "Categorias",
                newName: "ImagemCategoria_Url");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "administradores",
                newName: "Telefone_Numero");

            migrationBuilder.AddColumn<string>(
                name: "CpfUsuario_Numero",
                table: "comuns",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email_Endereco",
                table: "comuns",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CpfUsuario_Numero",
                table: "colaboradores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email_Endereco",
                table: "colaboradores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CpfUsuario_Numero",
                table: "administradores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email_Endereco",
                table: "administradores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CpfUsuario_Numero",
                table: "comuns");

            migrationBuilder.DropColumn(
                name: "Email_Endereco",
                table: "comuns");

            migrationBuilder.DropColumn(
                name: "CpfUsuario_Numero",
                table: "colaboradores");

            migrationBuilder.DropColumn(
                name: "Email_Endereco",
                table: "colaboradores");

            migrationBuilder.DropColumn(
                name: "CpfUsuario_Numero",
                table: "administradores");

            migrationBuilder.DropColumn(
                name: "Email_Endereco",
                table: "administradores");

            migrationBuilder.RenameColumn(
                name: "PrecoVenda_Valor",
                table: "Produtos",
                newName: "PrecoVenda");

            migrationBuilder.RenameColumn(
                name: "PrecoCusto_Valor",
                table: "Produtos",
                newName: "PrecoCusto");

            migrationBuilder.RenameColumn(
                name: "Imagem_Url",
                table: "Produtos",
                newName: "Imagem");

            migrationBuilder.RenameColumn(
                name: "Telefone_Numero",
                table: "comuns",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ValorTotal_Valor",
                table: "Comandas",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "Telefone_Numero",
                table: "colaboradores",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ImagemCategoria_Url",
                table: "Categorias",
                newName: "ImagemCategoria");

            migrationBuilder.RenameColumn(
                name: "Telefone_Numero",
                table: "administradores",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "ComumIdUsuario",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpfUsuario",
                table: "comuns",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "comuns",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CpfUsuario",
                table: "colaboradores",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "colaboradores",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CpfUsuario",
                table: "administradores",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "administradores",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ComumIdUsuario",
                table: "Produtos",
                column: "ComumIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_comuns_ComumIdUsuario",
                table: "Produtos",
                column: "ComumIdUsuario",
                principalTable: "comuns",
                principalColumn: "IdUsuario");
        }
    }
}
