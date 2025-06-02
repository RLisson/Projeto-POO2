using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Entidades;

namespace Trabalho_2.Factory
{
    public class AlunoFactory
    {
        public Aluno CriarInstancia(string nome, string cpf, Matricula matricula)
        {
            return new Aluno(nome, cpf, matricula);
        }

        public Aluno CriarInstancia(int id, string nome, string cpf, Matricula matricula)
        {
            return new Aluno(nome, cpf, matricula) { Id = id };
        }
    }
}
