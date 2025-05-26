using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Controller;

namespace Trabalho_2.View.Interface
{
    internal interface IProfessorView
    {
        void SetController(ProfessorController controller);
        string Id { get; set; }
        string Nome { get; set; }
        string CPF { get; set; }
    }
}
