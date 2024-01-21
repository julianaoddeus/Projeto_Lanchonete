using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.API.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
