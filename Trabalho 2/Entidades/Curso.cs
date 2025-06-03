using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Entidades.Abstrato;

namespace Trabalho2.Entidades
{
    public class Curso : IHasId, IComposite
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }
        public List<Aluno> Alunos { get; set; }
        public int Nivel { get; set; }

        public Curso() 
        {
            Turmas = new List<Turma>();
            Alunos = new List<Aluno>();
            Nivel = 1;

        }

        public Curso(string nome) : this()
        {
            Nome = nome;
        }

        public string Exibir()
        {
            return new string('-', Nivel) + Nome;
        }
    }
}
