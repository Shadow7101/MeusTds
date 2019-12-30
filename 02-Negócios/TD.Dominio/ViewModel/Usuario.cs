using System;
using System.Collections.Generic;

namespace TD.Dominio.ViewModel
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<string> DiretoriosDeAcesso { get; set; }
    }
}
