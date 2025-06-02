using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Entidades;

namespace Trabalho_2.Factory
{
    public class TurmaFactory
    {
        public Turma CriarInstancia(string nome, Professor professor, int capacidade)
        {
            return new Turma(nome, professor, capacidade);
        }

        public Turma CriarInstancia(int id, string nome, Professor professor, int capacidade)
        {
            return new Turma(nome, professor, capacidade)
            {
                Id = id
            };
        }
    }
}
