

namespace Lanchonete.API.Common.Helper.ImagensHelper
{
    public class ImagesHelper
    {
        public string ObterCaminhoURLLancheTradicional(string nomeDaImagem)
        {

            return $"D:\\00_GITHUB\\Projeto_Lanchonete\\Lanchonete.API\\Lanchonete.API\\wwwroot\\imagens\\lanches\\tradicional\\{nomeDaImagem}";
        }

        public string ObterCaminhoURLLancheNatural(string nomeDaImagem)
        {

            return $"D:\\00_GITHUB\\Projeto_Lanchonete\\Lanchonete.API\\Lanchonete.API\\wwwroot\\imagens\\lanches\\natural//{nomeDaImagem}";
        }
    }
}
