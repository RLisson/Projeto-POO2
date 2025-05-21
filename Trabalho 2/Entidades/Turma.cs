using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Entidades
{
    internal class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public List<Curso> Cursos { get; set; }
        public List<Aluno> Alunos { get; set; }
        public int Capacidade { get; set; }
    }
}
