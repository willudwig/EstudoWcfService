using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoWcfService
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public bool Salvar()
        {
            return true;
        }
    }
}