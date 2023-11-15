using ListaDeContatos.Data;
using ListaDeContatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext context)
        {
            _bancoContext = context;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public List<ContatoModel> BuscarContatos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Editar(ContatoModel contato)
        {
            _bancoContext.Contatos.Update(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Apagar(ContatoModel contato)
        {
            _bancoContext.Contatos.Remove(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel listarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(i => i.Id == id);
        }
    }
}
