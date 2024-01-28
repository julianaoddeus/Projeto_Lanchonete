using Lanchonete.API.Common.Helper.ImagensHelper;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanchonete.API.Migrations
{    
    public partial class PopulandoTabelaBedidas : Migration
    {
        private readonly ImagesHelper _imagesHelper;

        public PopulandoTabelaBedidas(ImagesHelper imagesHelper)
        {
            _imagesHelper = imagesHelper;
        }

        public PopulandoTabelaBedidas()
        {

        }
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var imagesHelper = new ImagesHelper();

            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId, Nome, Descricao, Preco,ImagemUrl, ImagemThumbmailUrl, EmEstoque)" +
            $"VALUES(3,'Uva','Suco natural 300ml', 17.50,'{imagesHelper.ObterCaminhoURLBebidas("uva")}','{imagesHelper.ObterCaminhoURLBebidas("uva")}',1)");
            
            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(3,'Goiaba','Suco natural 300ml', 17.50,'{imagesHelper.ObterCaminhoURLBebidas("goiaba")}','{imagesHelper.ObterCaminhoURLBebidas("goiaba")}',1)");
            
            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(3,'Laranja','Suco natural 300ml', 17.50,'{imagesHelper.ObterCaminhoURLBebidas("laranja")}','{imagesHelper.ObterCaminhoURLBebidas("laranja")}',1)");

            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
           $"VALUES(4,'Heineken','Logneck 450ml', 18.50,'{imagesHelper.ObterCaminhoURLBebidas("heineken")}','{imagesHelper.ObterCaminhoURLBebidas("heineken")}',1)");

            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(4,'Itaipava','Longneck 450ml', 18.50,'{imagesHelper.ObterCaminhoURLBebidas("itaipava")}','{imagesHelper.ObterCaminhoURLBebidas("itaipava")}',1)");

            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(4,'Theresopolis','Longneck 450ml', 18.50,'{imagesHelper.ObterCaminhoURLBebidas("theresopolis")}','{imagesHelper.ObterCaminhoURLBebidas("theresopolis")}',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Bebidas");
        }
    }
}
