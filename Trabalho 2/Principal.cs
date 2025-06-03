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
        TurmaView turmaView;
        CursoView cursoView;

        AlunoModel alunoModel;
        MatriculaModel matriculaModel;
        ProfessorModel professorModel;
        TurmaModel turmaModel;
        CursoModel cursoModel;

        public Principal()
        {
            InitializeComponent();
            this.alunoModel = AlunoModel.Instance();
            this.matriculaModel = MatriculaModel.Instance();
            this.professorModel = ProfessorModel.Instance();
            this.turmaModel = TurmaModel.Instance();
            this.cursoModel = CursoModel.Instance();
            matriculaModel.Iniciar();
            alunoModel.Iniciar();
            professorModel.Iniciar();
            turmaModel.Iniciar();
            cursoModel.Iniciar();
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

        private void btnCadastroTurmas_Click(object sender, EventArgs e)
        {
            turmaView = new TurmaView();
            TurmaController turmaController = new TurmaController(turmaModel, turmaView, professorModel, alunoModel);
            turmaView.Show();
        }

        private void btnCadastroCursos_Click(object sender, EventArgs e)
        {
            cursoView = new CursoView();
            CursoController cursoController = new CursoController(cursoModel, cursoView, turmaModel, alunoModel);
            cursoView.Show();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {

        }
    }
}
