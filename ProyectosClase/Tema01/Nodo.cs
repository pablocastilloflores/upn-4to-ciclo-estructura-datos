using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    internal class Nodo
    {
        private int dato;
        private Nodo? siguiente;

        public int Dato { get => dato; set => dato = value; }
        internal Nodo? Siguiente { get => siguiente; set => siguiente = value; }
    }
}
