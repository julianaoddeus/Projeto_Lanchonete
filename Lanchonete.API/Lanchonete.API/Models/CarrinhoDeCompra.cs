using Lanchonete.API.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Models
{
    public class CarrinhoDeCompra
    {
        private readonly AppDbContext _context;
        public CarrinhoDeCompra(AppDbContext context)
        {
            _context = context;
            CarrinhoCompraItens = new List<CarrinhoCompraItem>();
        }

        public string Id { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoDeCompra ObterCarrinho(IServiceProvider services)
        {
            //define a sessão
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem  um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            // obter ou gerar o id do carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //atribui o id a session
            session.SetString("CarrinhoId", carrinhoId);

            return new CarrinhoDeCompra(context)
            {
                Id = carrinhoId,
            };
        }

        public void AdionarAoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.FirstOrDefault(
                s => s.Lanche.Id == lanche.Id &&
                s.CarrinhoDeCompraId == Id);

            if (carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoDeCompraId = Id,
                    Lanche = lanche,
                    Quantidade = 1
                };
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else carrinhoCompraItem.Quantidade++;

            _context.SaveChanges();
        }

        public int RemoverDoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.FirstOrDefault(
                f => f.Lanche.Id == lanche.Id && 
                f.CarrinhoDeCompraId == Id);

            var quantidadeLocal = 0;

            if(carrinhoCompraItem != null)
            {
                if(carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
            }
            _context.SaveChanges();
           
            return quantidadeLocal;
        }

        public List<CarrinhoCompraItem> ObterCarrinhoCompraItens()
        {
            var result =  _context.CarrinhoCompraItens
                    .Where(w => w.CarrinhoDeCompraId == Id)
                    .Include(s => s.Lanche)
                    .ToList();
            return result;
        }

        public void LimparCarrinho()
        {
            var itensDoCarrinho = _context.CarrinhoCompraItens
                .Where(w => w.CarrinhoDeCompraId == Id);

            _context.CarrinhoCompraItens.RemoveRange(itensDoCarrinho);
            _context.SaveChanges();
        }

        public decimal ObterCarrinhoCompraTotal()
        {
           return _context.CarrinhoCompraItens
                .Where(w => w.CarrinhoDeCompraId == Id)
                .Select(s => s.Lanche.Preco * s.Quantidade).Sum();
        }
    }
}
