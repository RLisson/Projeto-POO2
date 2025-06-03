using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Entidades.Abstrato;
using Trabalho_2.Model.Abstrato;

namespace Trabalho_2.Acessa_dados.Interface
{
    public abstract class AcessaDados<T> where T : IHasId
    {
        protected Model<T> model;
        protected string arquivo;

        protected AcessaDados(string arquivo)
        {
            this.arquivo = arquivo;
        }

        public bool ExisteArquivo()
        {
            return File.Exists(arquivo);
        }

        public abstract void SetModel();
        public abstract void LeituraDados();
        public abstract void EscritaDados();
    }
}
