using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Model;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Acessa_dados
{
    public class AcessaDadosTurma : AcessaDados<Turma>
    {
        Model<Professor> _professorModel;
        Model<Aluno> _alunoModel;

        public AcessaDadosTurma(Model<Turma> model, string arquivo, Model<Professor> professorModel, Model<Aluno> alunoModel) : base(model, arquivo)
        {
            _professorModel = professorModel;
            _alunoModel = alunoModel;
        }

        public override void EscritaDados()
        {
            string linha = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(arquivo, false))
                    foreach (Turma turma in model.GetAll())
                    {
                        linha = $"{turma.Id};{turma.Nome};{turma.Capacidade};{turma.Professor.Id};";
                        if (turma.Alunos != null && turma.Alunos.Any())
                        {
                            linha += string.Join(";", turma.Alunos.Select(a => a.Id));
                        }
                        sw.WriteLine(linha);
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao escrever no arquivo!\n" + ex.Message);
            }
        }

        public override void LeituraDados()
        {
            string linha = "";
            Turma item;

            if (ExisteArquivo())
            {
                try
                {
                    int maxId = 0;
                    StreamReader sr = new StreamReader(arquivo);
                    char[] delimitador = { ';' };
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] campos = linha.Split(delimitador);
                        int id = int.Parse(campos[0]);
                        string nome = campos[1];
                        int capacidade = int.Parse(campos[2]);
                        int idProfessor = int.Parse(campos[3]);

                        Professor professor = _professorModel.Get(idProfessor);
                        List<Aluno> alunos = new List<Aluno>();
                        for (int i = 4; i < campos.Length; i++)
                        {
                            int idAluno = int.Parse(campos[i]);
                            Aluno aluno = _alunoModel.Get(idAluno);
                            alunos.Add(aluno);
                        }

                        item = new Turma(nome, professor, capacidade) { Id = id, Alunos = alunos };
                        model.AddNoId(item);
                        if (id > maxId)
                        {
                            maxId = id;
                        }

                    }
                    sr.Close();
                    model.idAtual = maxId + 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro!\n" + ex.Message);
                }
            }
        }
    }
}
