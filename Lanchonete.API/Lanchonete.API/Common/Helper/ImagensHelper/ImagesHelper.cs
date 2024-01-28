

namespace Lanchonete.API.Common.Helper.ImagensHelper
{
    public class ImagesHelper
    {
       
        public string ObterCaminhoURLLancheTradicional(string nomeDaImagem)
        {
          return $"~/imagens/lanches/tradicional/{nomeDaImagem}.png";
          
        }

        public string ObterCaminhoURLLancheNatural(string nomeDaImagem)
        {
            return $"~/imagens/lanches/natural/{nomeDaImagem}.png";
        }

        public string ObterCaminhoURLBebidas(string nomeDaImagem)
        {
            return $"~/imagens/bebidas/{nomeDaImagem}.png";

        }

        public string ObterCaminhoURLSobremesas(string nomeDaImagem)
        {
            return $"~/imagens/sobremesas/{nomeDaImagem}.png";
        }
    }
}
