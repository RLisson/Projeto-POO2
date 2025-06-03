using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2.Entidades.Abstrato
{
    public interface IComposite
    {
        int Nivel { get; set; }
        string Exibir();
    }
}
