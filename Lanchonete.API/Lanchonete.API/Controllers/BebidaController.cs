using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Lanchonete.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Controllers
{
    public class BebidaController : Controller
    {
        private readonly IBebidaRepositorio _bebidaRepositorio;

        public BebidaController(IBebidaRepositorio bebidaRepositorio)
        {
            _bebidaRepositorio = bebidaRepositorio;
        }

        public IActionResult Bebidas(string categoria)
        {
            IEnumerable<Bebida> bebidas;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                bebidas = _bebidaRepositorio.Bebidas.OrderBy(b => b.Id);
                categoriaAtual = "Bebidas";
            }
            else
            {
                bebidas = _bebidaRepositorio.Bebidas
                .Where(w => w.Categoria.Nome == categoria)
                .OrderBy(o => o.Nome);

                categoriaAtual = categoria;
            }

            var viewModel = new BebidaViewModel
            {
                Bebidas = bebidas,
                CategoriaAtual = categoriaAtual
            };
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var bebida = _bebidaRepositorio.Bebidas.FirstOrDefault(w => w.Id == id);
            return View(bebida);

        }

    }
}
