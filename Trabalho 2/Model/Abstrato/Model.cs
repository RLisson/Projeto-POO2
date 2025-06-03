using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Entidades.Abstrato;

namespace Trabalho_2.Model.Abstrato
{
    public abstract class Model<T> where T : IHasId
    {
        protected List<T> cadastro;
        public int idAtual { get; set; }
        protected AcessaDados<T> acessaDados;
        protected Model()
        {
            cadastro = new List<T>();
            idAtual = 0;
        }

        public void Iniciar()
        {
            acessaDados.SetModel();
            acessaDados.LeituraDados();
        }

        public void Add(T item)
        {
            item.Id = idAtual++;
            cadastro.Add(item);
            acessaDados.EscritaDados();
        }
        
        public void AddNoId(T item)
        {
            cadastro.Add(item);
        }

        public bool Remove(int id)
        {
            var item = cadastro.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                cadastro.Remove(item);
                acessaDados.EscritaDados();
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

        public bool Update(int id, T newItem)
        {
            var item = cadastro.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                item = newItem;
                acessaDados.EscritaDados();
                return true;
            }
            return false;
        }
    }
}
