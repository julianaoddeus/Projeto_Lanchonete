using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Lanchonete.API.Common.Helper.ImagensHelper
{
    public class ImagesHelper
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public ImagesHelper(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

       public string ObterCaminhoURLLancheTradicional(string nomeDaImagem)
        {
            var wwwrootPath = _hostingEnvironment.WebRootPath;
            return Path.Combine(wwwrootPath, "D:\\00_GITHUB\\Projeto_Lanchonete\\Lanchonete.API\\Lanchonete.API\\wwwroot\\imagens\\lanches\\tradicional", nomeDaImagem);
        }

        public string ObterCaminhoURLLancheNatural(string nomeDaImagem)
        {
            var wwwrootPath = _hostingEnvironment.WebRootPath;
            return Path.Combine(wwwrootPath, "D:\\00_GITHUB\\Projeto_Lanchonete\\Lanchonete.API\\Lanchonete.API\\wwwroot\\imagens\\lanches\\natural", nomeDaImagem);
        }
    }
}
