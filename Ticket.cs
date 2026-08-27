using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaTechGestionTickets.Lab1
{
    internal class Ticket
    {
        // Propiedades públicas del ticket
        public string Id { get;}
        public string Ubicacion { get; }
        public string TipoFalla { get; }
        public string Descripcion { get; }
        public string Prioridad { get; }
        public string Estado { get; set; }

        //Constructor de la clase Ticket
        public Ticket(string id, string ubicacion, string tipoFalla, string descripcion, string prioridad)
        {
            Id = id;
            Ubicacion = ubicacion;
            TipoFalla = tipoFalla;
            Descripcion = descripcion;
            Prioridad = prioridad;
            Estado = "Pendiente";
        }

        public override string ToString() // Sobrescribe el método ToString para mostrar la información del ticket de manera legible
        {
            return $"[{Id}] {TipoFalla} - {Descripcion} (Prioridad: {Prioridad}, Estado: {Estado})";
        }
    }
}
