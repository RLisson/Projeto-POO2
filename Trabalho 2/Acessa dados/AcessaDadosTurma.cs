using Newtonsoft.Json;
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
            try
            {
                var turmas = model.GetAll();
                string json = JsonConvert.SerializeObject(turmas, Formatting.Indented);
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
                    var turmas = JsonConvert.DeserializeObject<List<Turma>>(json);
                    if (turmas != null)
                    {
                        int maxId = 0;
                        foreach (var turma in turmas)
                        {
                            turma.Professor = _professorModel.Get(turma.Professor.Id);
                            turma.Alunos = turma.Alunos?.ConvertAll(a => _alunoModel.Get(a.Id));
                            model.AddNoId(turma);
                            if (turma.Id > maxId)
                            {
                                maxId = turma.Id;
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
