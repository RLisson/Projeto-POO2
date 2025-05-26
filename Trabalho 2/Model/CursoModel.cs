using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public class CursoModel : Model<Curso>
    {
        public bool AdicionarAluno(int id, Aluno aluno)
        {
            var curso = cadastro.FirstOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return false;
            }
            curso.Alunos.Add(aluno);
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
            return true;
        }
    }
}
