using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Strategy.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Strategy
{
    public class ValidacaoProfessor : IValidacaoStrategy<Professor>
    {
        public bool Validar(Professor item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) return false;
            if (string.IsNullOrWhiteSpace(item.CPF)) return false;
            return true;
        }
    }
}
