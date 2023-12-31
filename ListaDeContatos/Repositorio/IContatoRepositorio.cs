﻿using ListaDeContatos.Models;
using System.Collections.Generic;

namespace ListaDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {

        ContatoModel listarPorId(int id);

        List<ContatoModel> BuscarContatos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Editar(ContatoModel contato);
        bool Apagar(int id);
    }
}
