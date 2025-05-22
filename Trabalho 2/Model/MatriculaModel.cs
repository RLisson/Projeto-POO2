using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public class MatriculaModel : Model<Matricula>
    {
        public MatriculaModel() { }

        public bool Conflita(int numeroMatricula)
        {
            foreach (var matricula in cadastro)
            {
                if (matricula.Numero == numeroMatricula)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
