﻿using Lanchonete.API.Models;
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
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if(string.Equals("Tradicional", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepositorio.Lanches
                        .Where(w => w.Categoria.Nome.Equals("Tradicional"))
                        .OrderBy( o => o.Nome);
                }
                else
                {
                    lanches = _lancheRepositorio.Lanches
                        .Where(w => w.Categoria.Nome.Equals("Natural"))
                        .OrderBy(o => o.Nome);
                }
                categoriaAtual = categoria;
            }

            var viewModel = new NossosLanchesViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
            return View(viewModel);
        }

    }
}
