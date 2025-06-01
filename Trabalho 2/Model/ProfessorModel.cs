using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Acessa_dados;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public class ProfessorModel : Model<Professor>
    {
        public ProfessorModel() : base()
        {
            acessaDados = new AcessaDadosProfessor(this, "professores.txt");
        }
    }
}
