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
    public class AcessaDadosProfessor : AcessaDados<Professor>
    {
        private static AcessaDadosProfessor instance;
        private static readonly object lockObject = new object();

        public static AcessaDadosProfessor Instance(string arquivo)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new AcessaDadosProfessor(arquivo);
                    }
                }
            }
            return instance;
        }

        private AcessaDadosProfessor(string arquivo) : base(arquivo) {  }

        public override void SetModel()
        {
            this.model = ProfessorModel.Instance();

        }

        public override void EscritaDados()
        {
            try
            {
                var professores = model.GetAll();
                string json = JsonConvert.SerializeObject(professores, Formatting.Indented);
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
                    var professores = JsonConvert.DeserializeObject<List<Professor>>(json);
                    if (professores != null)
                    {
                        int maxId = 0;
                        foreach (var professor in professores)
                        {
                            model.AddNoId(professor);
                            if (professor.Id > maxId)
                            {
                                maxId = professor.Id;
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
