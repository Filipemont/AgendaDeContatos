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

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var contato = _contatoRepositorio.listarPorId(id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            _contatoRepositorio.Editar(contato);
            return RedirectToAction("Index");
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel identidade = _contatoRepositorio.listarPorId(id);
            return View(identidade);
        }
        public IActionResult Delete(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
