using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Model;
using Trabalho_2.Model.Abstrato;
using Trabalho_2.View;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Controller
{
    public class AlunoController
    {
        AlunoModel _model;
        IAlunoView _view;
        IModel<Matricula> _matriculaModel;

        public AlunoController(AlunoModel model, AlunoView view, IModel<Matricula> matriculaModel)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
            _matriculaModel = matriculaModel;
        }

        public void Add()
        {
            int numeroMatricula = int.Parse(_view.Matricula);
            Matricula matricula = new Matricula(numeroMatricula);
            _matriculaModel.Add(matricula);
            Aluno aluno = new Aluno(_view.Nome, _view.CPF, matricula);
            _model.Add(aluno);
        }

        public void Remove()
        {

        }
    }
}
