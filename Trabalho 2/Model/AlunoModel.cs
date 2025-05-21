using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public class AlunoModel : IModel<Aluno>
    {
        private List<Aluno> alunos;
        public int idAtual { get; private set; }

        public AlunoModel()
        {
            alunos = new List<Aluno>();
            idAtual = 0;
        }

        public void Add(Aluno aluno)
        {
            aluno.Id = idAtual;
            alunos.Add(aluno);
            idAtual++;
        }

        public bool Remove(int id)
        {
            Aluno aluno = alunos.FirstOrDefault(a => a.Id == id);
            if (aluno != null)
            {
                alunos.Remove(aluno);
                return true;
            }
            return false;
        }

        public Aluno Get(int id)
        {
            return alunos.FirstOrDefault(a => a.Id == id);
        }

        public List<Aluno> GetAll()
        {
            return alunos;
        }

        public Aluno GetByMatricula(int numero)
        {
            return alunos.FirstOrDefault(a => a.Matricula.Numero == numero);
        }
    }
}
