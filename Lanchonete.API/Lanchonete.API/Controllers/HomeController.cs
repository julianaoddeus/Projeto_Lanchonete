using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Lanchonete.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lanchonete.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepositorio _lacheRepositorio;

        public HomeController(ILancheRepositorio lacheRepositorio)
        {
            _lacheRepositorio = lacheRepositorio;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                LanchesPreferidos = _lacheRepositorio.LanchesPreferidos,
            };
            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
