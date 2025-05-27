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

        private void ClearDgv()
        {
            dgvProfessor.DataSource = null;
            dgvProfessor.Rows.Clear();
        }

        private void dgvProfessoresCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Professor professor = _controller.GetProfessorIndex(dgvProfessor.CurrentCell.RowIndex);
            Professor = professor.Id.ToString();
        }
    }
}
