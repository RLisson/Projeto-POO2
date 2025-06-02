using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2.Strategy.Interface
{
    public interface IValidacaoStrategy<T>
    {
        bool Validar(T item);
    }
}
