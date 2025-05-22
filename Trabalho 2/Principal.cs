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
using Trabalho_2.Model;
using Trabalho_2.View;
using Trabalho2.Entidades;

namespace Trabalho_2
{
    public partial class Principal : Form
    {
        AlunoView alunoView;
        AlunoModel alunoModel;
        MatriculaModel matriculaModel;

        public Principal(AlunoModel alunoModel, MatriculaModel matriculaModel)
        {
            InitializeComponent();
            this.alunoModel = alunoModel;

        }

        private void btnCadastroAlunos_Click(object sender, EventArgs e)
        {
            alunoView = new AlunoView();
            AlunoController alunoController = new AlunoController(alunoModel, alunoView, matriculaModel);
            alunoView.Show();
        }
    }
}
