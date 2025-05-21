using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Entidades
{
    internal class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }

    }
}
