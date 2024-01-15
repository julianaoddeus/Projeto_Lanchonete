

namespace Lanchonete.API.Common.Helper.ImagensHelper
{
    public class ImagesHelper
    {
       
        public string ObterCaminhoURLLancheTradicional(string nomeDaImagem)
        {
          return $"~/imagens/lanches/tradicional/{nomeDaImagem}.jpg";
          
        }

        public string ObterCaminhoURLLancheNatural(string nomeDaImagem)
        {
            return $"~/imagens/lanches/natural/{nomeDaImagem}.jpg";
        }
    }
}
