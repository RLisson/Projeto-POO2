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

        public static AcessaDadosAluno Instance(Model<Aluno> model, string arquivo, Model<Matricula> matriculaModel)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new AcessaDadosAluno(model, arquivo, matriculaModel);
                    }
                }
            }
            return instance;
        }

        private AcessaDadosAluno(Model<Aluno> model, string arquivo, Model<Matricula> matriculaModel) : base(model, arquivo)
        {
            _matriculaModel = matriculaModel;
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
