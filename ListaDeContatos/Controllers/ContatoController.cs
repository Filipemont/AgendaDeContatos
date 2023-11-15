using Microsoft.AspNetCore.Mvc;

namespace ListaDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
