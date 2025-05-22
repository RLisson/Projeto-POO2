using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Entidades.Abstrato;

namespace Trabalho_2.Model.Abstrato
{
    public abstract class Model<T> where T : IHasId
    {
        protected List<T> cadastro;
        public int idAtual { get; private set; }

        public Model()
        {
            cadastro = new List<T>();
            idAtual = 0;
        }

        public void Add(T item)
        {
            cadastro.Add(item);
            idAtual++;
        }

        public bool Remove(int id)
        {
            var item = cadastro.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                cadastro.Remove(item);
                return true;
            }
            return false;
        }

        public T Get(int id)
        {
            return cadastro.FirstOrDefault(item => item.Id == id);
        }

        public List<T> GetAll()
        {
            return cadastro;
        }

        public T GetIndex(int index)
        {
            return cadastro[index];
        }
    }
}
