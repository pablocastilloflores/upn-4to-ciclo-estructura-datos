using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaTechGestionTickets.Lab1
{
    internal class Nodo
    {
        public Ticket Dato { get; }
        public Nodo? Siguiente { get; set; }

        public Nodo(Ticket dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }    
}
