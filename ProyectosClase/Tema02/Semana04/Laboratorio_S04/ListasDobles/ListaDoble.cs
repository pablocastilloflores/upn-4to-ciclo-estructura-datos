using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobles
{
    internal class ListaDoble
    {
        public Nodo? cabeza { get; set; }
        public Nodo? cola { get; set; }

        public ListaDoble()
        {
            cabeza = null;
            cola = null;
        }
        public void insertarInicio(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (cabeza == null)
            {
                cabeza = nuevo;
                cola = nuevo;
            }
            else
            {
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
                cabeza = nuevo;
            }
        }
        public void insertarFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if(cola == null)
            {
                cabeza = nuevo;
                cola = nuevo;
            }
            else
            {
                cola.Siguiente = nuevo;
                nuevo.Anterior = cola;
                cola = nuevo;
            }
        }
        public bool eliminar(int valor)
        {
            Nodo? actual = cabeza;

            while (actual != null)
            {
                if(actual.Valor == valor)
                {
                    //1. Cuando existe un solo nodo
                    if(cabeza == cola)
                    {
                        cabeza = null;
                        cola = null;
                    }
                    //2. Cuando se elimina la cabeza
                    else if (actual == cabeza)
                    {
                        cabeza = cabeza.Siguiente;
                        cabeza.Anterior = null;
                    }
                    //3. Cuando se elimina la cola
                    else if(actual == cola)
                    {
                        cola = cola.Anterior;
                        cola.Siguiente = null;
                    }
                    //4. Eliminar un intermedio
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Anterior.Anterior = actual.Anterior;
                    }
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }
        public bool existe(int valor)
        {
            Nodo? actual = cabeza;

            while(actual != null)
            {
                if(actual.Valor == valor)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }
        public int buscar(int valor)
        {
            Nodo? actual = cabeza;
            int indice = 0;

            while (actual != null)
            {
                if (actual.Valor == valor)
                {
                    return indice;
                }
                actual = actual.Siguiente;
                indice++;
            }
            return -1;
        }
        public void limpiar()
        {
            cabeza = null;
            cola = null;
        }
    }
}
