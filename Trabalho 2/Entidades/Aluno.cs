using Trabalho_2.Entidades.Abstrato;
using Trabalho2.Entidades.Abstrato;

namespace Trabalho2.Entidades
{
    public class Aluno : Pessoa, IHasId, IComposite
    {
        public Matricula Matricula { get; set; }
        public int Nivel { get; set; } = 4;

        public Aluno(string nome, string cpf, Matricula matricula) : base(nome, cpf)
        {
            Matricula = matricula;
        }

        public string Exibir()
        {
            return new string('-', Nivel) + Nome;
        }
    }
}
