using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaMenu(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;           
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepositorio.Categorias.OrderBy(o => o.Nome);
            return View(categorias);
        }
    }
}
