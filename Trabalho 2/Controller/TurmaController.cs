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
    public class TurmaController
    {
        TurmaModel _model;
        ProfessorModel _professorModel;
        ITurmaView _view;
        AlunoModel _alunoModel;
        ValidacaoContext<Turma> _validacao;
        TurmaFactory _factory;

        public TurmaController(TurmaModel model, ITurmaView view, ProfessorModel professorModel, AlunoModel alunoModel)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
            _professorModel = professorModel;
            _alunoModel = alunoModel;
            _validacao = new ValidacaoContext<Turma>(new ValidacaoTurma());
            _factory = new TurmaFactory();
        }

        public void Add()
        {
            string nome = _view.Nome;
            int professorId = int.Parse(_view.Professor);
            int capacidade = int.Parse(_view.Capacidade);
            Professor professor = _professorModel.Get(professorId);
            if (professor == null)
            {
                MessageBox.Show("Professor não encontrado.");
                return;
            }
            Turma turma = _factory.CriarInstancia(nome, professor, capacidade);
            if (_validacao.ExecutarValidacao(turma) == false)
            {
                MessageBox.Show("Valores inválidos. Tente novamente");
                return;
            }
            _model.Add(turma);
            Clear();
        }

        public List<Professor> GetProfessores()
        {
            return _professorModel.GetAll();
        }

        public Professor GetProfessorIndex(int index)
        {
            return _professorModel.GetIndex(index);
        }

        public List<Turma> GetAll()
        {
            return _model.GetAll();
        }

        public Turma GetIndex(int index)
        {
            return _model.GetIndex(index);
        }

        public void Get()
        {
            Turma turma = _model.Get(int.Parse(_view.Id));
            if (turma != null)
            {
                _view.Id = turma.Id.ToString();
                _view.Nome = turma.Nome;
                _view.Professor = turma.Professor.Nome;
                _view.Capacidade = turma.Capacidade.ToString();
            }
            else
            {
                MessageBox.Show("Turma não encontrada.");
            }
        }
        
        public List<Turma> GetByProfessor()
        {
            int id = int.Parse(_view.Professor);
            return _model.GetByProfessor(id);
        }

        public void Remove()
        {
            var resultado = MessageBox.Show("Tem certeza que deseja remover?", "Confirmar remoção?", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(_view.Id);
                if (_model.Remove(id))
                {
                    MessageBox.Show("Sucesso!.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Turma não encontrada.");
                }
            }
        }

        public Aluno GetAlunoIndex(int index)
        {
            return _alunoModel.GetIndex(index);
        }

        public List<Aluno> GetAllAlunos()
        {
            return _alunoModel.GetAll();
        }

        public List<Aluno> GetAlunosTurma(int idTurma)
        {
            return _model.GetAlunosTurma(idTurma);
        }

        public void Clear()
        {
            _view.Id = "";
            _view.Nome = "";
            _view.Professor = "";
            _view.Capacidade = "";
        }

        public void AddAluno()
        {
            int idTurma = int.Parse(_view.Id);
            Turma turma = _model.Get(idTurma);

            int idAluno = int.Parse(_view.Aluno);
            Aluno aluno = _alunoModel.Get(idAluno);
            if (aluno == null)
            {
                MessageBox.Show("Aluno não encontrado.");
                return;
            }

            if (_model.AdicionarAluno(idTurma, aluno))
            {
                MessageBox.Show("Aluno adicionado com sucesso.");
            }
            else
            {
                MessageBox.Show("Capacidade da turma excedida.");
            }
            _view.Aluno = "";
        }
    }
}
