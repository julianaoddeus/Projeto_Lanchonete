using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanchonete.API.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao)"+
                "VALUES('Tradicional','Lanches feitos com ingredientes tradicionais')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao)" +
               "VALUES('Natural','Lanches feitos com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
