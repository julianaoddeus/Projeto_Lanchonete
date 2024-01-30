using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Lanchonete.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepositorio _lancheRepositorio;

        public LancheController(ILancheRepositorio lancheRepositorio)
        {
            _lancheRepositorio = lancheRepositorio;
        }
        public IActionResult NossosLanches(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepositorio.Lanches.OrderBy(lanche => lanche.Id);
                categoriaAtual = "Nossos Lanches";
            }
            else
            {
                lanches = _lancheRepositorio.Lanches
                .Where(w => w.Categoria.Nome == categoria)
                .OrderBy(o => o.Nome);

                categoriaAtual = categoria;
            }

            var viewModel = new NossosLanchesViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var lanche = _lancheRepositorio.Lanches.FirstOrDefault(w => w.Id == id);           
            return View(lanche);

        }

    }
}
