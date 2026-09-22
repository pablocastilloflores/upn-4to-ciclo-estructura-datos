using System;


namespace ListasCirculares
{
    internal class Nodo
    {
        public int Valor { get; set; }
        public Nodo? Siguiente { get; set; }
        public Nodo? Anterior { get; set; }

        public Nodo (int valor)
        {
            Valor = valor;
            Siguiente = null;
            Anterior = null;
        }

    }

}
