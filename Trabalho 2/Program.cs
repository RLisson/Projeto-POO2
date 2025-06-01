using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2.Model;

namespace Trabalho_2
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MatriculaModel matriculaModel = new MatriculaModel();
            AlunoModel alunoModel = new AlunoModel(matriculaModel);
            ProfessorModel professorModel = new ProfessorModel();
            TurmaModel turmaModel = new TurmaModel(professorModel, alunoModel);
            Application.Run(new Principal(alunoModel, matriculaModel, professorModel, turmaModel));
        }
    }
}
