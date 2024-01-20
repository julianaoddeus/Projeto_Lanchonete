using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanchonete.API.Migrations
{
    /// <inheritdoc />
    public partial class CarrinhoDeCompraItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraId",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoDeCompraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarrinhoDeCompraId",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoCompraId");
        }
    }
}
