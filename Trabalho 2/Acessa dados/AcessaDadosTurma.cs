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
        private static AcessaDadosTurma instance;
        private static readonly object lockObject = new object();

        Model<Professor> _professorModel;
        Model<Aluno> _alunoModel;

        public static AcessaDadosTurma Instance(string arquivo)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new AcessaDadosTurma(arquivo);
                    }
                }
            }
            return instance;
        }

        private AcessaDadosTurma(string arquivo) : base(arquivo) {  }

        public override void SetModel()
        {
            this.model = TurmaModel.Instance();
            _professorModel = ProfessorModel.Instance();
            _alunoModel = AlunoModel.Instance();
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
