using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Strategy.Interface;

namespace Trabalho_2.Strategy
{
    public class ValidacaoContext<T>
    {
        private readonly IValidacaoStrategy<T> _strategy;

        public ValidacaoContext(IValidacaoStrategy<T> strategy)
        {
            _strategy = strategy;
        }

        public bool ExecutarValidacao(T item)
        {
            return _strategy.Validar(item);
        }
    }
}
