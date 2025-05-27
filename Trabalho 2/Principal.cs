using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Trabalho_2.Controller;
using Trabalho_2.Model;
using Trabalho_2.View;
using Trabalho2.Entidades;

namespace Trabalho_2
{
    public partial class Principal : Form
    {
        AlunoView alunoView;
        ProfessorView professorView;

        AlunoModel alunoModel;
        MatriculaModel matriculaModel;
        ProfessorModel professorModel;

        public Principal(AlunoModel alunoModel, MatriculaModel matriculaModel, ProfessorModel professorModel)
        {
            InitializeComponent();
            this.alunoModel = alunoModel;
            this.matriculaModel = matriculaModel;
            this.professorModel = professorModel;
        }

        private void btnCadastroAlunos_Click(object sender, EventArgs e)
        {
            alunoView = new AlunoView();
            AlunoController alunoController = new AlunoController(alunoModel, alunoView, matriculaModel);
            alunoView.Show();
        }

        private void btnCadastroProfessores_Click(object sender, EventArgs e)
        {
            professorView = new ProfessorView();
            ProfessorController professorController = new ProfessorController(professorModel, professorView);
            professorView.Show();
        }
    }
}
