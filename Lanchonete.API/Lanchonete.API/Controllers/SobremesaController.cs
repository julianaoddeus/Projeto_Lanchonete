using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Lanchonete.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Controllers
{
    public class SobremesaController : Controller
    {
        private readonly ISobremesaRepositorio _sobremesaRepositorio;

        public SobremesaController(ISobremesaRepositorio sobremesaRepositorio)
        {
            _sobremesaRepositorio = sobremesaRepositorio;
        }
        public IActionResult Sobremesas(string categoria)
        {
            IEnumerable<Sobremesa> sobremesas;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                sobremesas = _sobremesaRepositorio.Sobremesas.OrderBy(s => s.Id);
                categoriaAtual = "Menu Sobremesas";
            }
            else
            {
                sobremesas = _sobremesaRepositorio.Sobremesas
                .Where(w => w.Categoria.Nome == categoria)
                .OrderBy(o => o.Nome);

                categoriaAtual = categoria;
            }

            var viewModel = new SobremesaViewModel
            {
                Sobremesas = sobremesas,
                CategoriaAtual = categoriaAtual
            };
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var sobremesa = _sobremesaRepositorio.Sobremesas.FirstOrDefault(w => w.Id == id);
            return View(sobremesa);

        }

    }
}
