using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaTechGestionTickets.Lab1
{
    internal class ListaEnlazadaTickets
    {
        private Nodo? _head;
        public ListaEnlazadaTickets()
        {
            _head = null;
        }
        public string Agregar(Ticket ticket)
        {
            string errores = TicketValidador.Validar(ticket);

            if (!string.IsNullOrEmpty(errores)) return errores;

            if (Buscar(ticket.Id) !=null) return $"Error: Ya existe un ticket con el ID '{ticket.Id}'.";
                          
            Nodo nuevo = new Nodo(ticket);

            if (_head == null)
            {
                _head = nuevo;
            }
            else
            {
                Nodo? actual = _head;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            return errores;
        }
        public string Listar()
        {
            if (_head == null)
                return "No hay tickets registrados.";

            string resultado = "";
            Nodo? actual = _head;

            while (actual != null)
            {
                resultado += actual.Dato.ToString() + Environment.NewLine;
                actual = actual.Siguiente;
            }

            return resultado;
        }
        public Ticket? Buscar(string id)
        {
            Nodo? actual = _head;

            while (actual != null)
            {
                if (actual.Dato.Id == id)
                {
                    return actual.Dato;
                }
                actual = actual.Siguiente;
            }

            return null;
        }
        public string Eliminar(string id)
        {
            if (_head == null)
                return "No hay tickets registrados.";

            //Caso 1: El ticket a eliminar es la cabeza
            if (_head.Dato.Id == id)
            {
                _head = _head.Siguiente;
                return $"Ticket '{id}' eliminado correctamente.";
            }

            //Caso 2: El ticket a eliminar está en otra posición (medio o final)

            Nodo? anterior = _head;
            Nodo? actual = _head.Siguiente;

            while (actual != null)
            {
                if(actual.Dato.Id == id)
                {
                    anterior.Siguiente = actual.Siguiente;
                    return $"Ticket '{id}' eliminado correctamente.";
                }
                anterior = actual;
                actual = actual.Siguiente;
            }

            //Caso 3: No se encontró el ticket
            return $"Error: No se encontró un ticket con el ID '{id}'.";
        }
        public int Contar()
        {
            int contador = 0;
            Nodo? actual = _head;

            while (actual != null)
            {
                if (actual.Dato.Estado == "Pendiente")
                    contador++;
                actual = actual.Siguiente;
            }    
            return contador;
        }
        public string Cerrar(string id)
        {
            Ticket? ticket = Buscar(id);

            if (ticket == null)
                return $"No se encontró ningún ticket con el ID '{id}'.";

            ticket.Estado = "Resuelto";
            return $"Ticket '{id}' marcado como Resuelto.";
        }
    }

}
