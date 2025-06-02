using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Strategy.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Strategy
{
    public class ValidacaoAluno : IValidacaoStrategy<Aluno>
    {
        public bool Validar(Aluno item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) return false;
            if (item.Matricula == null || item.Matricula.Numero <= 0) return false;
            return true;
        }
    }
}
