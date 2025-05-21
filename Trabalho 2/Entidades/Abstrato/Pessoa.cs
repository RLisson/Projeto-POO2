using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Entidades.Abstrato
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Pessoa() { }
        public Pessoa(string Nome, string CPF)
        {
            this.Nome = Nome;
            this.CPF = CPF;
        }
    }
}
