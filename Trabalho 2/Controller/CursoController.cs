using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2.Model;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.Controller
{
    public class CursoController
    {
        CursoModel _model;
        ICursoView _view;
        TurmaModel _turmaModel;
        AlunoModel _alunoModel;

        public CursoController(CursoModel model, ICursoView view, TurmaModel turmaModel, AlunoModel alunoModel)
        {
            _model = model;
            _view = view;
            view.SetController(this);
            _turmaModel = turmaModel;
            _alunoModel = alunoModel;
        }

        public void Add()
        {
            string nome = _view.Nome;

            Curso curso = new Curso(nome);
            _model.Add(curso);
        }

        public List<Curso> GetAll()
        {
            return _model.GetAll();
        }

        public Curso GetIndex(int index)
        {
            return _model.GetIndex(index);
        }

        public void Remove()
        {
            var resultado = MessageBox.Show("Tem certeza que deseja remover o curso?", "Confirmar remoção?", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(_view.Id);
                if (_model.Remove(id))
                {
                    MessageBox.Show("Curso removido com sucesso.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Curso não encontrado.");
                }
            }
        }

        public List<Turma> GetAllTurma()
        {
            return _turmaModel.GetAll();
        }

        public Turma GetTurmaIndex(int index)
        {
            return _turmaModel.GetIndex(index);
        }

        public void AdicionarTurma()
        {
            Turma turma = _turmaModel.Get(int.Parse(_view.Turma));
            if (_model.AdicionarTurma(int.Parse(_view.Id), turma))
            {
                MessageBox.Show("Turma adicionada com sucesso!");
            }
            else
            {
                MessageBox.Show("Curso não encontrado");
            }
        }

        public List<Aluno> GetAllAluno()
        {
            return _alunoModel.GetAll();
        }

        public Aluno GetAlunoIndex(int index)
        {
            return _alunoModel.GetIndex(index);
        }

        public void AddAluno()
        {
            Aluno aluno = _alunoModel.Get(int.Parse(_view.Aluno));
            if (_model.AdicionarAluno(int.Parse(_view.Id), aluno))
            {
                MessageBox.Show("Aluno adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Curso não encontrado");
            }
        }

        public List<Turma> GetTurmasCurso()
        {
            return _model.GetTurmasCurso(int.Parse(_view.Id));
        }

        public List<Aluno> GetAlunosCurso()
        {
            return _model.GetAlunosCurso(int.Parse(_view.Id));
        }

        public void Clear()
        {
            _view.Id = "";
            _view.Nome = "";
        }
    }
}
