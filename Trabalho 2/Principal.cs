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
using Trabalho_2.Acessa_dados;
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

        AcessaDadosRelatorio acessaDadosRelatorio;
        public Principal()
        {
            InitializeComponent();
            this.alunoModel = AlunoModel.Instance();
            this.matriculaModel = MatriculaModel.Instance();
            this.professorModel = ProfessorModel.Instance();
            this.turmaModel = TurmaModel.Instance();
            this.cursoModel = CursoModel.Instance();
            this.acessaDadosRelatorio = AcessaDadosRelatorio.Instance("relatorio.txt");
            matriculaModel.Iniciar();
            alunoModel.Iniciar();
            professorModel.Iniciar();
            turmaModel.Iniciar();
            cursoModel.Iniciar();
            acessaDadosRelatorio.SetModel();
        }

        private void btnCadastroAlunos_Click(object sender, EventArgs e)
        {
            alunoView = new AlunoView();
            AlunoController alunoController = new AlunoController(alunoView);
            alunoView.Show();
        }

        private void btnCadastroProfessores_Click(object sender, EventArgs e)
        {
            professorView = new ProfessorView();
            ProfessorController professorController = new ProfessorController(professorView);
            professorView.Show();
        }

        private void btnCadastroTurmas_Click(object sender, EventArgs e)
        {
            turmaView = new TurmaView();
            TurmaController turmaController = new TurmaController(turmaView);
            turmaView.Show();
        }

        private void btnCadastroCursos_Click(object sender, EventArgs e)
        {
            cursoView = new CursoView();
            CursoController cursoController = new CursoController(cursoView);
            cursoView.Show();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            acessaDadosRelatorio.EscritaDados();
            MessageBox.Show("Relatório gerado com sucesso!");
        }
    }
}
