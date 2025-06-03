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
    public sealed class TurmaModel : Model<Turma>
    {
        private static readonly Lazy<TurmaModel> instance = new Lazy<TurmaModel>(() => new TurmaModel());
        public static TurmaModel Instance() => instance.Value;

        private TurmaModel()
        {
            acessaDados = AcessaDadosTurma.Instance("turmas.json");
        }

        public bool AdicionarAluno(int id, Aluno aluno)
        {
            Turma turma = Get(id);
            if (turma == null || turma.Alunos.Count >= turma.Capacidade)
            {
                return false;
            }
            turma.Alunos.Add(aluno);
            acessaDados.EscritaDados();
            return true;
        }

        public List<Turma> GetByProfessor(int id)
        {
            return cadastro.FindAll(t => t.Professor.Id == id);
        }

        public List<Aluno> GetAlunosTurma(int idTurma)
        {
            Turma turma = Get(idTurma);
            return turma.Alunos;
        }
    }
}
