using ListaDeContatos.Models;
using System.Collections.Generic;

namespace ListaDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarContatos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Editar(ContatoModel contato);
        ContatoModel Apagar(ContatoModel contato);
    }
}
