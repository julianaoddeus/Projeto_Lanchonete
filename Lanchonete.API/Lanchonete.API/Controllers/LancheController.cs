using Lanchonete.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.API.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepositorio _lancheRepositorio;

        public LancheController(ILancheRepositorio lancheRepositorio)
        {
            _lancheRepositorio = lancheRepositorio;
        }
        public IActionResult NossosLanches()
        {
            var lanches = _lancheRepositorio.lanches;
            return View(lanches);
        }

    }
}
