using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Acessa_dados
{
    public class AcessaDadosCurso : AcessaDados<Curso>
    {
        private static AcessaDadosCurso instance;
        private static readonly object lockObject = new object();

        Model<Turma> _modelTurma;
        Model<Aluno> _modelAluno;

        public static AcessaDadosCurso Instance(Model<Curso> model, string arquivo, Model<Turma> modelTurma, Model<Aluno> modelAluno)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new AcessaDadosCurso(model, arquivo, modelTurma, modelAluno);
                    }
                }
            }
            return instance;
        }
        private AcessaDadosCurso(Model<Curso> model, string arquivo, Model<Turma> modelTurma, Model<Aluno> modelAluno) : base(model, arquivo)
        {
            _modelTurma = modelTurma;
            _modelAluno = modelAluno;
        }

        public override void EscritaDados()
        {
            try
            {
                var cursos = model.GetAll();
                string json = JsonConvert.SerializeObject(cursos, Formatting.Indented);
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
                    var cursos = JsonConvert.DeserializeObject<List<Curso>>(json);
                    if (cursos != null)
                    {
                        int maxId = 0;
                        foreach (var curso in cursos)
                        {
                            curso.Turmas = curso.Turmas?.ConvertAll(t => _modelTurma.Get(t.Id));
                            curso.Alunos = curso.Alunos?.ConvertAll(a => _modelAluno.Get(a.Id));
                            model.AddNoId(curso);
                            if (curso.Id > maxId)
                            {
                                maxId = curso.Id;
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
