using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Entidades.Abstrato;
using Trabalho_2.Model.Abstrato;

namespace Trabalho_2.Acessa_dados.Interface
{
    public interface IAcessaDados<T> where T : IHasId
    {
        void SetModel(Model<T> model, string arquivo);
        bool ExisteArquivo();
        void LeituraDados();
        void EscritaDados();
    }
}
