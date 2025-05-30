using System;
using System.Collections.Generic;
using System.IO;
using Trabalho_2.Acessa_dados.Interface;
using Trabalho_2.Model;
using Trabalho_2.Model.Abstrato;
using Trabalho2.Entidades;

namespace Trabalho_2.Acessa_dados
{
    public class AcessaDadosAluno : AcessaDados<Aluno>
    {
        public AcessaDadosAluno() { }

        public override void EscritaDados()
        {
            string linha = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                    foreach (Aluno aluno in model.GetAll())
                    {
                        linha = $"{aluno.Id};{aluno.Nome};{aluno.CPF};{aluno.Matricula.Numero}";
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
            Aluno item;

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
                        if (campos.Length >= 3)
                        {
                            int id = int.Parse(campos[0]);
                            string nome = campos[1];
                            string cpf = campos[2];
                            int numeroMatricula = int.Parse(campos[3]);

                            Matricula matricula = new Matricula(numeroMatricula);
                            item = new Aluno(nome, cpf, matricula) { Id = id };
                            model.AddNoId(item);
                            if (id > maxId)
                            {
                                maxId = id;
                            }
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
