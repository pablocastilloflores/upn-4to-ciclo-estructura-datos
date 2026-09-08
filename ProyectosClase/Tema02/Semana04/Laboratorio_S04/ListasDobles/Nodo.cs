using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobles
{
    internal class Nodo
    {
        public Nodo (int valor)
        {
            Valor = valor;
            Siguiente = null;
            Anterior = null;
        }
        public int Valor { get; set; }
        public Nodo Siguiente{ get; set; }
        public Nodo Anterior { get; set; }
    }
}
