using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCantina.Data.Migrations
{
    /// <inheritdoc />
    public partial class configEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_colaboradores_VendedorIdUsuario",
                table: "Comandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_comuns_ClienteIdUsuario",
                table: "Comandas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comuns",
                table: "comuns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_colaboradores",
                table: "colaboradores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_administradores",
                table: "administradores");

            migrationBuilder.RenameTable(
                name: "comuns",
                newName: "Comuns");

            migrationBuilder.RenameTable(
                name: "colaboradores",
                newName: "Colaboradores");

            migrationBuilder.RenameTable(
                name: "administradores",
                newName: "Administradores");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Produtos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Categorias",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comuns",
                table: "Comuns",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colaboradores",
                table: "Colaboradores",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_Colaboradores_VendedorIdUsuario",
                table: "Comandas",
                column: "VendedorIdUsuario",
                principalTable: "Colaboradores",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_Comuns_ClienteIdUsuario",
                table: "Comandas",
                column: "ClienteIdUsuario",
                principalTable: "Comuns",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_Colaboradores_VendedorIdUsuario",
                table: "Comandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_Comuns_ClienteIdUsuario",
                table: "Comandas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comuns",
                table: "Comuns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colaboradores",
                table: "Colaboradores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores");

            migrationBuilder.RenameTable(
                name: "Comuns",
                newName: "comuns");

            migrationBuilder.RenameTable(
                name: "Colaboradores",
                newName: "colaboradores");

            migrationBuilder.RenameTable(
                name: "Administradores",
                newName: "administradores");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DataCriacao",
                table: "Produtos",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DataCriacao",
                table: "Categorias",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comuns",
                table: "comuns",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_colaboradores",
                table: "colaboradores",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_administradores",
                table: "administradores",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_colaboradores_VendedorIdUsuario",
                table: "Comandas",
                column: "VendedorIdUsuario",
                principalTable: "colaboradores",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_comuns_ClienteIdUsuario",
                table: "Comandas",
                column: "ClienteIdUsuario",
                principalTable: "comuns",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
