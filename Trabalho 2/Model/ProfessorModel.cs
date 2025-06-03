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
    public sealed class ProfessorModel : Model<Professor>
    {
        private static readonly Lazy<ProfessorModel> instance = new Lazy<ProfessorModel>(() => new ProfessorModel());
        public static ProfessorModel Instance() => instance.Value;
 
        private ProfessorModel() : base()
        {
            acessaDados = AcessaDadosProfessor.Instance("professores.json");
            acessaDados.LeituraDados();
        }
    }
}
