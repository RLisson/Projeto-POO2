using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Controller;

namespace Trabalho_2.View.Interface
{
    public interface IAlunoView
    {
        void SetController(AlunoController controller);
        string Id { get; set; }
        string Nome { get; set; }
        string CPF { get; set; }
        string Matricula { get; set; }
    }
}
