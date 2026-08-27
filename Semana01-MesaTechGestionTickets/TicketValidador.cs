using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaTechGestionTickets.Lab1
{
    internal static class TicketValidador // static evita que se pueda instanciar la clase, ya que solo contiene métodos estáticos
    {
        //Métodos con cuerpo de expresión para validar los campos del ticket (=>)
        public static bool EsIdValido(string id) => !string.IsNullOrWhiteSpace(id);
        public static bool EsUbicacionValida(string ubicacion) => !string.IsNullOrWhiteSpace(ubicacion);
        public static bool EsTipoFallaValido(string tipoFalla) => !string.IsNullOrWhiteSpace(tipoFalla);
        public static bool EsDescripcionValida(string descripcion) => !string.IsNullOrWhiteSpace(descripcion);
        public static bool EsPrioridadValida(string prioridad) => prioridad == "Alta" || prioridad == "Media" || prioridad == "Baja";

        // Método para validar un ticket y devolver una lista de errores
        public static string Validar (Ticket ticket) 
        {
            string errores = "";
            //+= se utiliza para concatenar cadenas de texto (apila los errores)
            if (!EsIdValido(ticket.Id))
                errores += "El código (Id) no puede estar vacío.\n";
            if (!EsUbicacionValida(ticket.Ubicacion))
                errores += "La ubicación no puede estar vacía.\n";
            if (!EsTipoFallaValido(ticket.TipoFalla))
                errores += "El tipo de falla no puede estar vacío.\n";
            if (!EsDescripcionValida(ticket.Descripcion))
                errores += "La descripción no puede estar vacía.\n";
            if (!EsPrioridadValida(ticket.Prioridad))
                errores += "La prioridad debe ser Alta, Media o Baja.\n";

            return errores;
        }
    }
}
