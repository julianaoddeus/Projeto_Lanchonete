using Lanchonete.API.Common.Helper.ImagensHelper;
using Microsoft.EntityFrameworkCore.Migrations;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


#nullable disable

namespace Lanchonete.API.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        private readonly ImagesHelper _imagesHelper;
        public PopularLanches(ImagesHelper imagesHelper)
        {
            _imagesHelper = imagesHelper;
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {
     
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(1,'X-Bacon','Pão brioche/Queijo/Hamburger/Bacon/Molho','Pão brioche, Blend 100% Angus, queijo cheddar artesanal, cebola caramelizada, bacon tiras e molho ranch',22.50,'{_imagesHelper.ObterCaminhoURLLancheTradicional("x-bacon")}','{_imagesHelper.ObterCaminhoURLLancheTradicional("x-bacon")}',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(1,'X-Burger','Pão brioche/Queijo/Molho','Pão brioche,hamburger artesanal Angus 150g, queijo mussarela, molho cheddar',26.50,'{_imagesHelper.ObterCaminhoURLLancheTradicional("x-burger")}','{_imagesHelper.ObterCaminhoURLLancheTradicional("x-burger")}',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(1,'X-DuploBancon','Pão brioche/Queijo/Hamburger/Molho','Pão de Brioche C/ Gergelim, Blend 100% Angus, Queijo Meia Cura, Tomate, Rúcula, Maionese Artesanal de Ervas',29.50,'{_imagesHelper.ObterCaminhoURLLancheTradicional("x-duplo-bacon")}','{_imagesHelper.ObterCaminhoURLLancheTradicional("x-duplo-bacon")}',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(1,'X-DuploBurger','Pão brioche/Queijo/Hamburger/Molho','Pão de brioche com gergelim, Blend 100% Angus, queijo cheddar, Picles de cebola roxa, Molho Especial Fabuloso Burger',28.50,'{_imagesHelper.ObterCaminhoURLLancheTradicional("x-duplo-burger")}','{_imagesHelper.ObterCaminhoURLLancheTradicional("x-duplo-burger")}',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(1,'X-Futuro','Pão brioche/Queijo/Hamburger/Molho','Pão de Smash, Carne Esmagada, Queijo Prato e Maionese de Alho',27.50,'{_imagesHelper.ObterCaminhoURLLancheTradicional("x-futuro")}','{_imagesHelper.ObterCaminhoURLLancheTradicional("x-futuro")}',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(1,'X-Salada','Pão brioche/Queijo/Hamburger/Molho','Pão de brioche prime, Blend 100% Angus, queijo gorgonzola, geleia de damasco, chips de bacon',28.50,'{_imagesHelper.ObterCaminhoURLLancheTradicional("x-salada")}','{_imagesHelper.ObterCaminhoURLLancheTradicional("x-salada")}',0,1)");                        
   
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(2,'N-Presunto','Pão integral/Queijo/Presunto/Maionese','Pão de forma, alface ou rúcula, cenoura picada, maionese temperada e fatias de presunto defumado',28.50,'{_imagesHelper.ObterCaminhoURLLancheNatural("n-presunto")}','{_imagesHelper.ObterCaminhoURLLancheNatural("n-presunto")}',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(2,'N-Peru','Pão integral/Queijo/Peru/Maionese','Pão de forma, alface ou rúcula, cenoura picada, maionese temperada e peito de peru',28.50,'{_imagesHelper.ObterCaminhoURLLancheNatural("n-peru")}','{_imagesHelper.ObterCaminhoURLLancheNatural("n-peru")}',0,1)");
           
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome, DescricaoReduzida,Descricao,Preco,ImagemUrl,ImagemThumbmailUrl, EhLanchePreferido, EmEstoque)" +
               $"VALUES(2,'N-Frango','Pão integral/Frango/Maionese','Pão de forma, alface ou rúcula, cenoura picada, maionese temperada e frango desfiado',28.50,'{_imagesHelper.ObterCaminhoURLLancheNatural("n-frango")}','{_imagesHelper.ObterCaminhoURLLancheNatural("n-frango")}',0,1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
