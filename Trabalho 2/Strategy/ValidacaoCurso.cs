using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Strategy.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Strategy
{
    public class ValidacaoCurso : IValidacaoStrategy<Curso>
    {
        public bool Validar(Curso item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) return false;
            return true;
        }
    }
}
