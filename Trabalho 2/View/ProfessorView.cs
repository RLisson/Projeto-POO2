using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2.Controller;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.View
{
    public partial class ProfessorView : Form, IProfessorView
    {
        ProfessorController _controller;

        public ProfessorView()
        {
            InitializeComponent();
        }

        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public string Nome { get => txtNome.Text; set => txtNome.Text = value; }
        public string CPF { get => txtCpf.Text; set => txtCpf.Text = value; }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _controller.Add();
        }

        void IProfessorView.SetController(ProfessorController controller)
        {
            _controller = controller;
        }

        private void dgvProfessorCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Professor professor = _controller.GetIndex(dgvProfessor.CurrentRow.Index);
            Id = professor.Id.ToString();
            Nome = professor.Nome;
            CPF = professor.CPF;
            dgvProfessor.Visible = false;
        }

        private void ClearDgv()
        {
            dgvProfessor.DataSource = null;
            dgvProfessor.Rows.Clear();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvProfessor.DataSource = _controller.GetAll();
            dgvProfessor.Visible = true;
            dgvProfessor.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            _controller.Get();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.Remove();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _controller.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProfessorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dgvProfessor.Visible = false;
            }
        }
    }
}
