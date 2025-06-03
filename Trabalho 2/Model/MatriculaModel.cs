using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Acessa_dados;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Model
{
    public sealed class MatriculaModel : Model<Matricula>
    {
        private static readonly Lazy<MatriculaModel> instance = new Lazy<MatriculaModel>(() => new MatriculaModel());
        public static MatriculaModel Instance() => instance.Value;

        private MatriculaModel() : base()
        {
            acessaDados = AcessaDadosMatricula.Instance("matriculas.json");
            acessaDados.LeituraDados();
        }

        public bool Conflita(int numeroMatricula)
        {
            foreach (var matricula in cadastro)
            {
                if (matricula.Numero == numeroMatricula)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
