using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model;
using Trabalho_2.View;

namespace Trabalho_2.Controller
{
    public class AlunoController
    {
        AlunoModel _model;
        AlunoView _view;

        public AlunoController(AlunoModel model, AlunoView view)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
        }
    }
}
