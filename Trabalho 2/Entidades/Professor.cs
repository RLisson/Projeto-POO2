using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Entidades.Abstrato;
using Trabalho2.Entidades.Abstrato;

namespace Trabalho2.Entidades
{
    public class Professor : Pessoa, IHasId
    {

        public Professor() : base() { }
        public Professor(string nome, string cpf) : base(nome, cpf) { }
    }
}
