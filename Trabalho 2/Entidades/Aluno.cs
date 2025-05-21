using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Entidades.Abstrato;

namespace Trabalho2.Entidades
{
    public class Aluno : Pessoa
    {
        public Matricula Matricula { get; set; }

        public Aluno(string nome, string cpf, Matricula matricula) : base(nome, cpf)
        {
            Matricula = matricula;
        }
    }
}
