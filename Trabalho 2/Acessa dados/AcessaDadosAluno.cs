using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Model;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Acessa_dados
{
    public sealed class AcessaDadosAluno : AcessaDados<Aluno>
    {
        private static AcessaDadosAluno instance;
        private static readonly object lockObject = new object();

        Model<Matricula> _matriculaModel;

        public static AcessaDadosAluno Instance(string arquivo)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new AcessaDadosAluno(arquivo);
                    }
                }
            }
            return instance;
        }

        private AcessaDadosAluno(string arquivo) : base(arquivo) {  }

        public override void SetModel()
        {
            this.model = AlunoModel.Instance();
            _matriculaModel = MatriculaModel.Instance();
        }

        public override void EscritaDados()
        {
            try
            {
                var alunos = model.GetAll();
                string json = JsonConvert.SerializeObject(alunos, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(arquivo, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao escrever no arquivo JSON!\n" + ex.Message);
            }
        }

        public override void LeituraDados()
        {
            if (ExisteArquivo())
            {
                try
                {
                    string json = File.ReadAllText(arquivo);
                    var alunos = JsonConvert.DeserializeObject<List<Aluno>>(json);
                    if (alunos != null)
                    {
                        int maxId = 0;
                        foreach (var aluno in alunos)
                        {
                            aluno.Matricula = _matriculaModel.Get(aluno.Matricula.Id);
                            model.AddNoId(aluno);
                            if (aluno.Id > maxId)
                            {
                                maxId = aluno.Id;
                            }
                        }
                        model.idAtual = maxId + 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao ler o arquivo JSON!\n" + ex.Message);
                }
            }
        }
    }
}
