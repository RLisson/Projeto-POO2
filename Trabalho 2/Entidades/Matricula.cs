﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_2.Entidades.Abstrato;

namespace Trabalho2.Entidades
{
    public class Matricula : IHasId
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public Matricula() { }
        public Matricula(int numero)
        {
            Numero = numero;
        }
    }
}
