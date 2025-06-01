using System;
using System.Collections;
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
    public partial class CursoView : Form, ICursoView
    {
        CursoController _controller;
        public CursoView()
        {
            InitializeComponent();
        }

        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public string Nome { get => txtNome.Text; set => txtNome.Text = value; }
        public string Turma { get => txtTurma.Text; set => txtTurma.Text = value; }
        public string Aluno { get => txtAluno.Text; set => txtAluno.Text = value; }

        public void SetController(CursoController controller)
        {
            _controller = controller;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _controller.Add();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            SetDgvData(dgvCursos, _controller.GetAll());
        }

        private void CloseDgv(DataGridView dgv, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dgv.Visible = false;
            }
        }

        private void dgvCursosCellDoubleClickl(object sender, DataGridViewCellEventArgs e)
        {
            Curso curso = _controller.GetIndex(dgvCursos.CurrentRow.Index);
            Id = curso.Id.ToString();
            Nome = curso.Nome;
            dgvCursos.Visible = false;
        }

        private void dgvCursosKeyDown(object sender, KeyEventArgs e)
        {
            CloseDgv(dgvCursos, e);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.Remove();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SetDgvData(dgvTurmas, _controller.GetAllTurma());
        }

        private void dgvTurmas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Turma turma = _controller.GetTurmaIndex(dgvTurmas.CurrentRow.Index);
            Turma = turma.Id.ToString();
            dgvTurmas.Visible = false;
        }

        private void dgvTurmas_KeyDown(object sender, KeyEventArgs e)
        {
            CloseDgv(dgvTurmas, e);
        }

        private void btnAdicionarTurma_Click(object sender, EventArgs e)
        {
            _controller.AdicionarTurma();
        }

        private void ClearDgv(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
        }

        private void SetDgvData(DataGridView dgv, IList source)
        {
            ClearDgv(dgv);
            dgv.DataSource = source;
            dgv.Visible = true;
            dgv.Focus();
        }

        private void btnSelecionarAluno_Click(object sender, EventArgs e)
        {
            SetDgvData(dgvAlunos, _controller.GetAllAluno());
        }

        private void dgvAlunos_KeyDown(object sender, KeyEventArgs e)
        {
            CloseDgv(dgvAlunos, e);
        }

        private void dgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aluno aluno = _controller.GetAlunoIndex(dgvAlunos.CurrentRow.Index);
            txtAluno.Text = aluno.Id.ToString();
            dgvAlunos.Visible = false;
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            _controller.AddAluno();
        }

        private void CursoView_Load(object sender, EventArgs e)
        {

        }

        private void btnExibirTurmas_Click(object sender, EventArgs e)
        {
            SetDgvData(dgvTurmas, _controller.GetTurmasCurso());
        }

        private void btnExibirAlunos_Click(object sender, EventArgs e)
        {
            SetDgvData(dgvAlunos, _controller.GetAlunosCurso());
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
