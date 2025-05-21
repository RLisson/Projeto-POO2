using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public class MatriculaModel : IModel<Matricula>
    {
        List<Matricula> matriculas;
        public int idAtual { get; private set; }

        public MatriculaModel()
        {
            matriculas = new List<Matricula>();
            idAtual = 0;
        }


        public void Add(Matricula item)
        {
            item.Id = idAtual;
            matriculas.Add(item);
            idAtual++;
        }

        public Matricula Get(int id)
        {
            return matriculas.FirstOrDefault(m => m.Id == id);
        }

        public List<Matricula> GetAll()
        {
            return matriculas;
        }

        public bool Remove(int id)
        {
            Matricula matricula = matriculas.FirstOrDefault(m => m.Id == id);
            if (matricula != null)
            {
                matriculas.Remove(matricula);
                return true;
            }
            return false;
        }
    }
}
