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

        }

    }
}
