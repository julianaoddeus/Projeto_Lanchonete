using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Lanchonete.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Controllers
{
    public class CarrinhoDeCompraController : Controller
    {
        private readonly ILancheRepositorio _lancheRepositorio;
        private readonly CarrinhoDeCompra _carrinhoDeCompra;

        public CarrinhoDeCompraController(
            ILancheRepositorio lancheRepositorio,
            CarrinhoDeCompra carrinhoCompra)
        {
            _lancheRepositorio = lancheRepositorio;
            _carrinhoDeCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoDeCompra.ObterCarrinhoCompraItens();            
            _carrinhoDeCompra.CarrinhoCompraItens = itens;

            var carrinhoItensViewModel = new CarrinhoDeCompraViewModel
            {
                CarrinhoDeCompra = _carrinhoDeCompra,
                CarrinhoDeCompraTotal = _carrinhoDeCompra.ObterCarrinhoCompraTotal()

            };

            return View(carrinhoItensViewModel);

        }

        public IActionResult AdicionarItemNoCarrinhoDeCompra(int id)
        {
            var lancheSelecionado = _lancheRepositorio.Lanches.FirstOrDefault(lanche => lanche.Id == id);

            if (lancheSelecionado != null)
                _carrinhoDeCompra.AdionarAoCarrinho(lancheSelecionado);

            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoDeCompra(int id)
        {
            var lancheSelecionado = _lancheRepositorio.Lanches.FirstOrDefault(lanche => lanche.Id == id);

            if (lancheSelecionado != null)
                _carrinhoDeCompra.RemoverDoCarrinho(lancheSelecionado);

            return RedirectToAction("Index");
        }

    }
}
