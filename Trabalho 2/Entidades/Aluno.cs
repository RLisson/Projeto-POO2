using Trabalho_2.Entidades.Abstrato;
using Trabalho2.Entidades.Abstrato;

namespace Trabalho2.Entidades
{
    public class Aluno : Pessoa, IHasId
    {
        public Matricula Matricula { get; set; }
        public Aluno(string nome, string cpf, Matricula matricula) : base(nome, cpf)
        {
            Matricula = matricula;
        }
    }
}
