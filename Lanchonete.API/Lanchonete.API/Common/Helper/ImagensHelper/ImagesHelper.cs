

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

        public string ObterCaminhoURLBebidaNatural(string nomeDaImagem)
        {
            return $"~/imagens/bebidas/sucos/{nomeDaImagem}.png";

        }

        public string ObterCaminhoURLBebidaAlcoolica(string nomeDaImagem)
        {
            return $"~/imagens/bebidas/cervejas/{nomeDaImagem}.png";

        }

        public string ObterCaminhoURLSobremesas(string nomeDaImagem)
        {
            return $"~/imagens/sobremesas/{nomeDaImagem}.png";
        }
    }
}
