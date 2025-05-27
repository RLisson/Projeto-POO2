using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model;
using Trabalho_2.View;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Controller
{
    public class TurmaController
    {
        TurmaModel _model;
        ProfessorModel _professorModel;

        ITurmaView _view;

        public TurmaController(TurmaModel model, ITurmaView view, ProfessorModel professorModel)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
            _professorModel = professorModel;
        }

        public List<Professor> GetProfessores()
        {
            return _professorModel.GetAll();
        }

        public Professor GetProfessorIndex(int index)
        {
            return _professorModel.GetIndex(index);
        }
    }
}
