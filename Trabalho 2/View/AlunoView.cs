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

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CPF { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Matricula { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void SetController(AlunoController controller)
        {
            _controller = controller;
        }
    }
}
