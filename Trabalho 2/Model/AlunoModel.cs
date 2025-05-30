using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public class AlunoModel : Model<Aluno>
    {

        public AlunoModel() : base()
        {
            acessaDados.SetModel(this, "alunos.csv");
            acessaDados.LeituraDados();
        }

        public Aluno GetByMatricula(int numero)
        {
            return cadastro.FirstOrDefault(a => a.Matricula.Numero == numero);
        }
    }
}
