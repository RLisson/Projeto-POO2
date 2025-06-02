using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2.Entidades;

namespace Trabalho_2.Factory
{
    public class CursoFactory
    {
        public Curso CriarInstancia(string nome)
        {
            return new Curso(nome);
        }

        public Curso CriarInstancia(int id, string nome)
        {
            return new Curso(nome) { Id = id };
        }
    }
}
