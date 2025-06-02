using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Entidades;

namespace Trabalho_2.Factory
{
    public class ProfessorFactory
    {
        public Professor CriarInstancia(string nome, string cpf)
        {
            return new Professor(nome, cpf);
        }

        public Professor CriarInstancia(int id, string nome, string cpf)
        {
            return new Professor(nome, cpf) { Id = id };
        }
    }
}
