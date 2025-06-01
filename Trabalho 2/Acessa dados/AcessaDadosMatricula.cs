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
    public class AcessaDadosMatricula : AcessaDados<Matricula>
    {
        public AcessaDadosMatricula(Model<Matricula> model, string arquivo) : base(model, arquivo) { }

        public override void EscritaDados()
        {
            try
            {
                var matriculas = model.GetAll();
                string json = JsonConvert.SerializeObject(matriculas, Formatting.Indented);
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
                    var matriculas = JsonConvert.DeserializeObject<List<Matricula>>(json);
                    if (matriculas != null)
                    {
                        int maxId = 0;
                        foreach (var matricula in matriculas)
                        {
                            model.AddNoId(matricula);
                            if (matricula.Id > maxId)
                            {
                                maxId = matricula.Id;
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
