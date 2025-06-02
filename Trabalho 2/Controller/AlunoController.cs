using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2.Acessa_dados;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Model;
using Trabalho_2.Model.Abstrato;
using Trabalho_2.Strategy;
using Trabalho_2.Strategy.Interface;
using Trabalho_2.View;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Controller
{
    public class AlunoController
    {
        AlunoModel _model;
        AlunoView _view;
        MatriculaModel _matriculaModel;
        ValidacaoContext<Aluno> _validacao;

        public AlunoController(AlunoModel model, AlunoView view, MatriculaModel matriculaModel)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
            _matriculaModel = matriculaModel;
            _validacao = new ValidacaoContext<Aluno>(new ValidacaoAluno());
        }

        public void Add()
        {
            int numeroMatricula = int.Parse(_view.Matricula);
            if (_matriculaModel.Conflita(numeroMatricula))
            {
                MessageBox.Show("Número de matrícula já cadastrado.");
                return;
            }
            Matricula matricula = new Matricula(numeroMatricula);
            _matriculaModel.Add(matricula);
            Aluno aluno = new Aluno(_view.Nome, _view.CPF, matricula);
            if (_validacao.ExecutarValidacao(aluno) == false)
            {
                MessageBox.Show("Valores inválidos. Tente novamente");
                return;
            }
            _model.Add(aluno);
            Clear();
        }


        public void Remove()
        {
            var resultado = MessageBox.Show("Tem certeza que deseja remover o aluno?", "Confirmar remoção?", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int idAluno = int.Parse(_view.Id);
                Aluno aluno = _model.Get(idAluno);
                if (aluno != null)
                {
                    Matricula matricula = _matriculaModel.Get(aluno.Matricula.Id);
                    _matriculaModel.Remove(matricula.Id);
                    _model.Remove(idAluno);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado.");
                }
            }

        }

        public void Get()
        {
            Aluno aluno = _model.Get(int.Parse(_view.Id));
            if (aluno != null)
            {
                _view.Id = aluno.Id.ToString();
                _view.Nome = aluno.Nome;
                _view.CPF = aluno.CPF;
                _view.Matricula = aluno.Matricula.Numero.ToString();
            }
            else
            {
                MessageBox.Show("Aluno não encontrado.");
            }

        }

        public List<Aluno> GetAll()
        {
            return _model.GetAll();
        }

        public void GetByMatricula()
        {
            int numeroMatricula = int.Parse(_view.Matricula);
            Aluno aluno = _model.GetByMatricula(numeroMatricula);
            if (aluno != null)
            {
                _view.Id = aluno.Id.ToString();
                _view.Nome = aluno.Nome;
                _view.CPF = aluno.CPF;
                _view.Matricula = aluno.Matricula.Numero.ToString();
            }
            else
            {
                MessageBox.Show("Aluno não encontrado.");
            }
        }

        public Aluno GetByIndex(int index)
        {
            return _model.GetIndex(index);
        }

        public void Update()
        {
            int idAluno = int.Parse(_view.Id);
            Aluno aluno = _model.Get(idAluno);
            if (aluno != null)
            {
                aluno.Nome = _view.Nome;
                aluno.CPF = _view.CPF;
                aluno.Matricula.Numero = int.Parse(_view.Matricula);
                if (_validacao.ExecutarValidacao(aluno) == false)
                {
                    MessageBox.Show("Valores inválidos. Tente novamente");
                    return;
                }
                _model.Update(idAluno, aluno);
                Clear();
            }
            else
            {
                MessageBox.Show("Aluno não encontrado.");
            }
        }

        public void Clear()
        {
            _view.Id = "";
            _view.Nome = "";
            _view.CPF = "";
            _view.Matricula = "";
        }
    }
}
