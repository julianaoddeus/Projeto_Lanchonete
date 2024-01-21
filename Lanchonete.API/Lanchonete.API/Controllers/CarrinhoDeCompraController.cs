using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Lanchonete.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lanchonete.API.Controllers
{
    public class CarrinhoDeCompraController : Controller
    {
        private readonly ILancheRepositorio __lancheRepositorio;
        private readonly CarrinhoDeCompra _carrinhoDeCompra;

        public CarrinhoDeCompraController(
            ILancheRepositorio lancheRepositorio,
            CarrinhoDeCompra carrinhoCompra)
        {
            __lancheRepositorio = lancheRepositorio;
            _carrinhoDeCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoDeCompra.ObterCarrinhoCompraItens();
            _carrinhoDeCompra.CarrinhoCompraItens = itens;

            var carrinhoItensviewModel = new CarrinhoDeCompraViewModel
            {
                CarrinhoDeCompra = _carrinhoDeCompra,
                CarrinhoDeCompraTotal = _carrinhoDeCompra.ObterCarrinhoCompraTotal()

            };

            return View(carrinhoItensviewModel);

        }

        public IActionResult AdicionarItemNoCarrinhoDeCompra(int id)
        {
            var lancheSelecionado = __lancheRepositorio.Lanches.FirstOrDefault(lanche => lanche.Id == id);

            if (lancheSelecionado != null)
                _carrinhoDeCompra.AdionarAoCarrinho(lancheSelecionado);

            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoDeCompra(int id)
        {
            var lancheSelecionado = __lancheRepositorio.Lanches.FirstOrDefault(lanche => lanche.Id == id);

            if (lancheSelecionado != null)
                _carrinhoDeCompra.RemoverDoCarrinho(lancheSelecionado);

            return RedirectToAction("Index");
        }

    }
}
