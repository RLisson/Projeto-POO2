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
        public AcessaDadosMatricula(Model<Matricula> model, string arquivo) : base(model, arquivo)
        {
        }

        public override void EscritaDados()
        {
            string linha = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                    foreach (Matricula matricula in model.GetAll())
                    {
                        linha = $"{matricula.Id};{matricula.Numero}";
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
            Matricula item;

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
                        int numero = int.Parse(campos[1]);

                        item = new Matricula(numero) { Id = id };
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
