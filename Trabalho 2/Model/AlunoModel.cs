using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public class AlunoModel
    {
        List<Aluno> alunos;

        private void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        private bool RemoverAluno(int id)
        {
            Aluno aluno = alunos.FirstOrDefault(a => a.Id == id);
            if (aluno != null)
            {
                alunos.Remove(aluno);
                return true;
            }
            return false;
        }

        public Aluno GetAluno(int id)
        {
            return alunos.FirstOrDefault(a => a.Id == id);
        }

        public List<Aluno> GetAll()
        {
            return alunos;
        }

        public Aluno GetAlunoByMatricula(int numero)
        {
            return alunos.FirstOrDefault(a => a.Matricula.Numero == numero);
        }
    }
}
