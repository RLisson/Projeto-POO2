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
    public sealed class CursoModel : Model<Curso>
    {
        private static readonly Lazy<CursoModel> instance = new Lazy<CursoModel>(() => new CursoModel());
        public static CursoModel Instance() => instance.Value;

        private CursoModel() : base()
        {
            acessaDados = AcessaDadosCurso.Instance("cursos.json");
            acessaDados.LeituraDados();
        }

        public bool AdicionarAluno(int id, Aluno aluno)
        {
            var curso = cadastro.FirstOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return false;
            }
            curso.Alunos.Add(aluno);
            acessaDados.EscritaDados();
            return true;
        }

        public bool AdicionarTurma(int id, Turma turma)
        {
            var curso = cadastro.FirstOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return false;
            }
            curso.Turmas.Add(turma);
            acessaDados.EscritaDados();
            return true;
        }

        public List<Aluno> GetAlunosCurso(int id)
        {
            Curso curso = Get(id);
            return curso.Alunos;
        }

        public List<Turma> GetTurmasCurso(int id)
        {
            Curso curso = Get(id);
            return curso.Turmas;

        }
    }
}
