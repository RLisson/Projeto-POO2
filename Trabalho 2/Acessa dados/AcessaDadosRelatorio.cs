using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Model;
using Trabalho2.Entidades;

namespace Trabalho_2.Acessa_dados
{
    public class AcessaDadosRelatorio : AcessaDados<Curso>
    {
        private static AcessaDadosRelatorio instance;
        private static readonly object lockObject = new object();

        private AcessaDadosRelatorio(string arquivo) : base(arquivo)
        {
        }
        public static AcessaDadosRelatorio Instance(string arquivo)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new AcessaDadosRelatorio(arquivo);
                    }
                }
            }
            return instance;
        }
        public override void EscritaDados()
        {
            string linha = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                {
                    foreach (var curso in model.GetAll())
                    {
                        linha = curso.Exibir();
                        sw.WriteLine(linha);
                        foreach (var turma in curso.Turmas)
                        {
                            linha = turma.Exibir();
                            sw.WriteLine(linha);
                            linha = turma.Professor.Exibir();
                            sw.WriteLine(linha);
                            foreach (var aluno in turma.Alunos)
                            {
                                linha = aluno.Exibir();
                                sw.WriteLine(linha);
                            }
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        public override void LeituraDados()
        {
            throw new NotImplementedException();
        }

        public override void SetModel()
        {
            this.model = CursoModel.Instance();
        }
    }
}
