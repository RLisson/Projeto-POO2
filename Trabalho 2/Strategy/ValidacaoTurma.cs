using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Strategy.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Strategy
{
    public class ValidacaoTurma : IValidacaoStrategy<Turma>
    {
        public bool Validar(Turma item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) return false;
            if (item.Professor == null) return false;
            return true;
        }
    }
}
