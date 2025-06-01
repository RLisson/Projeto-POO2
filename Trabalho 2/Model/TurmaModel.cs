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
    public class TurmaModel : Model<Turma>
    {
        public TurmaModel(Model<Professor> professorModel, Model<Aluno> alunoModel)
        {
            acessaDados = new AcessaDadosTurma(this, "turmas.json", professorModel, alunoModel);
            acessaDados.LeituraDados();
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
