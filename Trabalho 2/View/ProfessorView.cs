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

        }

        void IProfessorView.SetController(ProfessorController controller)
        {
            _controller = controller;
        }
    }
}
