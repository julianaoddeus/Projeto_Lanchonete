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
            $"VALUES(3,'Uva','Suco natural 300ml', 17.50,'{imagesHelper.ObterCaminhoURLBebidaNatural("uva")}','{imagesHelper.ObterCaminhoURLBebidaNatural("uva")}',1)");
            
            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(3,'Goiaba','Suco natural 300ml', 17.50,'{imagesHelper.ObterCaminhoURLBebidaNatural("goiaba")}','{imagesHelper.ObterCaminhoURLBebidaNatural("goiaba")}',1)");
            
            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(3,'Laranja','Suco natural 300ml', 17.50,'{imagesHelper.ObterCaminhoURLBebidaNatural("laranja")}','{imagesHelper.ObterCaminhoURLBebidaNatural("laranja")}',1)");

            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
           $"VALUES(4,'Heineken','Logneck 450ml', 18.50,'{imagesHelper.ObterCaminhoURLBebidaAlcoolica("heineken")}','{imagesHelper.ObterCaminhoURLBebidaAlcoolica("heineken")}',1)");

            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(4,'Itaipava','Longneck 450ml', 18.50,'{imagesHelper.ObterCaminhoURLBebidaAlcoolica("itaipava")}','{imagesHelper.ObterCaminhoURLBebidaAlcoolica("itaipava")}',1)");

            migrationBuilder.Sql("INSERT INTO Bebidas(CategoriaId,Nome,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl,EmEstoque)" +
            $"VALUES(4,'Theresopolis','Longneck 450ml', 18.50,'{imagesHelper.ObterCaminhoURLBebidaAlcoolica("theresopolis")}','{imagesHelper.ObterCaminhoURLBebidaAlcoolica("theresopolis")}',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Bebidas");
        }
    }
}
