using System;
using System.Numerics;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListaDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
    }
}
