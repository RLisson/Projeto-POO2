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

        public AcessaDadosProfessor() { }

        public override void EscritaDados()
        {
            string linha = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                    foreach (Professor professor in model.GetAll())
                    {
                        linha = $"{professor.Id};{professor.Nome};{professor.CPF}";
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
            Professor item;

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
                        string cpf = campos[2];

                        item = new Professor(nome, cpf) { Id = id };
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
