using ListaDeContatos.Models;
using ListaDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ListaDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            var contatos =_contatoRepositorio.BuscarContatos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }


        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            _contatoRepositorio.Editar(contato);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(ContatoModel contato)
        {
            _contatoRepositorio.Apagar(contato);
            return RedirectToAction("Index");
        }
    }
}
