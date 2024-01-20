using Lanchonete.API.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.API.Models
{
    public class CarrinhoDeCompra
    {
        private readonly AppDbContext _context;
        public CarrinhoDeCompra(AppDbContext context)
        {
            _context = context;
        }

        public string Id { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoDeCompra ObterCarrinho(IServiceProvider services)
        {
            //define a sessão
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem  um serviço do tipo do nosso contexto
            var appDbContext = services.GetService<AppDbContext>();

            // obter ou gerar o id do carrinho
            string carrinhoId = session.GetString("id") ?? Guid.NewGuid().ToString();

            //atribui o id a session
            session.SetString("Id", carrinhoId);

            return new CarrinhoDeCompra(appDbContext)
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
            }
            else carrinhoCompraItem.Quantidade++;

            _context.SaveChanges();
        }

        public void RemoverDoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.FirstOrDefault(f => f.Lanche.Id == lanche.Id && f.CarrinhoDeCompraId == Id);
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
           
        }

        public List<CarrinhoCompraItem> ObterCarrinhoCompraItens()
        {
            return CarrinhoCompraItens ?? (CarrinhoCompraItens = _context.CarrinhoCompraItens
                    .Where(w => w.CarrinhoDeCompraId == Id)
                    .Include(s => s.Lanche)
                    .ToList());
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
