using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Controller;

namespace Trabalho_2.View.Interface
{
    public interface ICursoView
    {
        void SetController(CursoController controller);
        string Id { get; set; }
        string Nome { get; set; }
        string Turma { get; set; }
        string Aluno { get; set; }
    }
}
