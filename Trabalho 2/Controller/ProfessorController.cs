using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2.Acessa_dados;
using Trabalho_2.Factory;
using Trabalho_2.Model;
using Trabalho_2.Strategy;
using Trabalho_2.View;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Controller
{
    public class ProfessorController
    {
        ProfessorModel _model;
        IProfessorView _view;
        ValidacaoContext<Professor> _validacao;
        ProfessorFactory _factory;

        public ProfessorController(ProfessorModel model, ProfessorView view)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
            _validacao = new ValidacaoContext<Professor>(new ValidacaoProfessor());
            _factory = new ProfessorFactory();
        }

        public void Add()
        {
            string nome = _view.Nome;
            string cpf = _view.CPF;
            Professor professor = _factory.CriarInstancia(nome, cpf);
            if (_validacao.ExecutarValidacao(professor) == false)
            {
                MessageBox.Show("Valores inválidos. Tente novamente");
                return;
            }
            _model.Add(professor);
            Clear();
        }

        public void Remove()
        {
            var resultado = MessageBox.Show("Tem certeza que deseja remover o aluno?", "Confirmar remoção?", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(_view.Id);
                if (_model.Remove(id))
                {
                    MessageBox.Show("Professor removido com sucesso.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Professor não encontrado.");
                }
            }
        }

        public void Get()
        {
            int id = int.Parse(_view.Id);
            Professor professor = _model.Get(id);
            if (professor != null)
            {
                _view.Nome = professor.Nome;
                _view.CPF = professor.CPF;
            }
            else
            {
                MessageBox.Show("Professor não encontrado.");
            }
        }

        public List<Professor> GetAll()
        {
            return _model.GetAll();
        }

        public Professor GetIndex(int index)
        {
            return _model.GetIndex(index);
        }

        public void Clear()
        {
            _view.Id = string.Empty;
            _view.Nome = string.Empty;
            _view.CPF = string.Empty;
        }
    }
}
    