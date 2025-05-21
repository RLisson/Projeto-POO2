using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2.Model.Abstrato
{
    public interface IModel<T>
    {
        int idAtual { get; }
        void Add(T item);
        bool Remove(int id);
        T Get(int id);
        List<T> GetAll();
    }
}
