using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2.Controller;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.View
{
    public partial class TurmaView : Form, ITurmaView
    {
        TurmaController _controller;

        public TurmaView()
        {
            InitializeComponent();
        }

        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public string Nome { get => txtNome.Text; set => txtNome.Text = value; }
        public string Professor { get => txtProfessor.Text; set => txtProfessor.Text = value; }
        public string Capacidade { get => txtCapacidade.Text; set => txtCapacidade.Text = value; }
        public string Aluno { get => txtAluno.Text; set => txtAluno.Text = value; }

        public void SetController(TurmaController controller)
        {
            _controller = controller;
        }

        private void TurmaView_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            dgvProfessor.DataSource = _controller.GetProfessores();
            dgvProfessor.Visible = true;
            dgvProfessor.Focus();
        }

        private void ClearDgvProfessor()
        {
            dgvProfessor.DataSource = null;
            dgvProfessor.Rows.Clear();
        }

        private void ClearDgv()
        {
            dgvTurmas.DataSource = null;
            dgvTurmas.Rows.Clear();
        }

        private void dgvProfessoresCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Professor professor = _controller.GetProfessorIndex(dgvProfessor.CurrentCell.RowIndex);
            Professor = professor.Id.ToString();
            dgvProfessor.Visible = false;
        }

        private void btnExibirTurmas_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvTurmas.DataSource = _controller.GetAll();
            dgvTurmas.Visible = true;
            dgvTurmas.Focus();
        }

        private void dgvTurmasKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dgvTurmas.Visible = false;
            }
        }

        private void dgvTurmasCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Turma turma = _controller.GetIndex(dgvTurmas.CurrentCell.RowIndex);
            Id = turma.Id.ToString();
            Nome = turma.Nome;
            Professor = turma.Professor.Id.ToString();
            Capacidade = turma.Capacidade.ToString();
            dgvTurmas.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarTurma_Click(object sender, EventArgs e)
        {
            _controller.Add();
        }

        private void btnConsultarPorProfessor_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvTurmas.DataSource = _controller.GetByProfessor();
            dgvTurmas.Visible = true;
            dgvTurmas.Focus();
        }

        private void btnRemoverTurma_Click(object sender, EventArgs e)
        {
            _controller.Remove();
        }

        private void btnSelecionarAluno_Click(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = _controller.GetAllAlunos();
            dgvAlunos.Visible = true;
            dgvAlunos.Focus();
        }

        private void ClearDgvAlunos()
        {
            dgvAlunos.DataSource = null;
            dgvAlunos.Rows.Clear();
        }

        private void dgvAlunosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aluno aluno = _controller.GetAlunoIndex(dgvAlunos.CurrentCell.RowIndex);
            txtAluno.Text = aluno.Id.ToString();
            dgvAlunos.Visible = false;
        }

        private void dgvAlunosKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dgvAlunos.Visible = false;
            }
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            _controller.AddAluno();
        }

        private void dgvProfessoresKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dgvProfessor.Visible = false;
            }
        }

        private void btnExibirAlunos_Click(object sender, EventArgs e)
        {
            ClearDgvAlunos();
            dgvAlunos.DataSource = _controller.GetAlunosTurma(int.Parse(Id));
            dgvAlunos.Visible = true;
            dgvAlunos.Focus();
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
