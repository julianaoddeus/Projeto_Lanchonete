using Lanchonete.API.Models;
using Lanchonete.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lanchonete.API.Components
{
    public class CarrinhoDeCompraResumo : ViewComponent
    {
        private readonly CarrinhoDeCompra _carrinhoDeCompra;
        public CarrinhoDeCompraResumo(CarrinhoDeCompra carrinhoDeCompra)
        {
            _carrinhoDeCompra = carrinhoDeCompra;
        }
        public IViewComponentResult Invoke()
        {
            //var itens = _carrinhoDeCompra.ObterCarrinhoCompraItens();
            var itens = new List<CarrinhoCompraItem>
            {
                new CarrinhoCompraItem(),
                new CarrinhoCompraItem()
            };
            _carrinhoDeCompra.CarrinhoCompraItens = itens;

            var carrinhoItensviewModel = new CarrinhoDeCompraViewModel
            {
                CarrinhoDeCompra = _carrinhoDeCompra,
                CarrinhoDeCompraTotal = _carrinhoDeCompra.ObterCarrinhoCompraTotal()

            };

            return View(carrinhoItensviewModel);
        }
        
    }
}
