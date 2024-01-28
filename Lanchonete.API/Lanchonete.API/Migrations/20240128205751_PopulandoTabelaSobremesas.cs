using Lanchonete.API.Common.Helper.ImagensHelper;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanchonete.API.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoTabelaSobremesas : Migration
    {
        private readonly ImagesHelper _imagesHelper;

        public PopulandoTabelaSobremesas(ImagesHelper imagesHelper)
        {
            _imagesHelper = imagesHelper;
        }

        public PopulandoTabelaSobremesas()
        {

        }
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var imagesHelper = new ImagesHelper();

            migrationBuilder.Sql("INSERT INTO Sobremesas(CategoriaId, Nome, Descricao, Preco, ImagemUrl, ImagemThumbmailUrl, EmEstoque)" +
            $"VALUES(5,'Bolo de Chocolate','pedaço de 180g', 17.50,'{imagesHelper.ObterCaminhoURLSobremesas("bolo_chocolate")}','{imagesHelper.ObterCaminhoURLSobremesas("bolo_chocolate")}',1)");

            migrationBuilder.Sql("INSERT INTO Sobremesas(CategoriaId, Nome, Descricao, Preco, ImagemUrl, ImagemThumbmailUrl, EmEstoque)" +
            $"VALUES(5,'Bolo deMorango','pedaço de 180g', 17.50,'{imagesHelper.ObterCaminhoURLSobremesas("bolo_morango")}','{imagesHelper.ObterCaminhoURLSobremesas("bolo_morango")}',1)");

            migrationBuilder.Sql("INSERT INTO Sobremesas(CategoriaId, Nome, Descricao, Preco, ImagemUrl, ImagemThumbmailUrl, EmEstoque)" +
            $"VALUES(5,'Cupcake','120g cada', 11.50,'{imagesHelper.ObterCaminhoURLSobremesas("cupcake")}','{imagesHelper.ObterCaminhoURLSobremesas("cupcake")}',1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Sobremesas");
        }
    }
}
