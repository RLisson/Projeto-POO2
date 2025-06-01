using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Entidades.Abstrato;

namespace Trabalho2.Entidades
{
    public class Turma : IHasId
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }
        public int Capacidade { get; set; }

        public Turma()
        {
            Alunos = new List<Aluno>();
        }

        public Turma(string nome, Professor professor, int capacidade) : this()
        {
            Nome = nome;
            Professor = professor;
            Capacidade = capacidade;
        }
    }
}
