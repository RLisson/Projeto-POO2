using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Controller;

namespace Trabalho_2.View.Interface
{
    internal interface IAlunoView
    {
        void SetController(AlunoController controller);
        int Id { get; set; }
        string Nome { get; set; }
        string CPF { get; set; }
        int Matricula { get; set; }
    }
}
