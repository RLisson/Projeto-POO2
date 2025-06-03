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
    public sealed class AlunoModel : Model<Aluno>
    {
        private static readonly Lazy<AlunoModel> instance = new Lazy<AlunoModel>(() => new AlunoModel());
        public static AlunoModel Instance() => instance.Value;

        private AlunoModel() : base()
        {
            acessaDados = AcessaDadosAluno.Instance("alunos.json");
            acessaDados.LeituraDados();
        }

        public Aluno GetByMatricula(int numero)
        {
            return cadastro.FirstOrDefault(a => a.Matricula.Numero == numero);
        }
    }
}
