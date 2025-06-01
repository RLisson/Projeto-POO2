using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2.Controller;
using Trabalho_2.View.Interface;
using Trabalho2.Entidades;

namespace Trabalho_2.View
{
    public partial class AlunoView : Form, IAlunoView
    {
        AlunoController _controller;


        // Implementação interface
        public string Id
        {
            get => txtId.Text;
            set => txtId.Text = value;
        }
        public string Nome 
        {
            get => txtNome.Text;
            set => txtNome.Text = value; 
        }
        public string CPF 
        { 
            get => txtCPF.Text; 
            set => txtCPF.Text = value; 
        }
        public string Matricula 
        {
            get => txtMatricula.Text;
            set => txtMatricula.Text = value; 
        }
        public void SetController(AlunoController controller)
        {
            _controller = controller;
        }
        //

        public AlunoView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _controller.Add();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.Remove();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            _controller.Get();
        }

        private void btnConsultaMatricula_Click(object sender, EventArgs e)
        {
            _controller.GetByMatricula();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = null;
            dgvAlunos.Rows.Clear();
            dgvAlunos.DataSource = _controller.GetAll();
            dgvAlunos.Columns["Id"].DisplayIndex = 0;
            dgvAlunos.Visible = true;
            dgvAlunos.Focus();
        }

        private void dgvAlunosKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                dgvAlunos.Visible = false;
            }
        }

        private void dgvAlunosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAlunosCelltDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvAlunos.CurrentRow.Index;
            Aluno aluno = _controller.GetByIndex(linha);
            Id = aluno.Id.ToString();
            Nome = aluno.Nome;
            CPF = aluno.CPF;
            Matricula = aluno.Matricula.Numero.ToString();

            dgvAlunos.Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _controller.Update();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _controller.Clear();
        }
    }
}
