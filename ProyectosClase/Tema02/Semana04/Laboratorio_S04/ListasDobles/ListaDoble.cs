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
                        actual.Siguiente.Anterior = actual.Anterior;
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
        public List<int> ObtenerInverso()
        {
            List<int> elementos = new List<int>();
            Nodo? actual = cola;

            while (actual != null)
            {
                elementos.Add(actual.Valor);
                actual = actual.Anterior;
            }
            return elementos;
        }
        public int obtenerTamanio()
        {
            int contador = 0;
            Nodo? actual = cabeza;

            while(actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }
        public bool insertarPosicion(int valor, int pos)
        {
            int tamanio = obtenerTamanio();

            if (pos < 0 || pos > tamanio)
                return false;

            if(pos == 0)
            {
                insertarInicio(valor);
                return true;
            }

            if(pos == tamanio)
            {
                insertarFinal(valor);
                return true;
            }

            //Insertar en medio

            Nodo? nuevo = new Nodo(valor);
            Nodo? actual = cabeza;

            //Avanzar hasta el nodo anterior donde se insertará
            for (int i = 0; i < pos - 1; i++)
            {
                actual = actual!.Siguiente;
            }
            //Para los nodos que salen del nuevo
            nuevo.Siguiente = actual!.Siguiente;
            nuevo.Anterior = actual;

            //Para los nodos que van hacia nuevo
            actual.Siguiente!.Anterior = nuevo;
            actual.Siguiente = nuevo;
            return true;
        }
        public bool eliminarPosicion(int pos)
        {
            int tamanio = obtenerTamanio();
            if(cabeza == null || pos < 0 || pos > tamanio)
                return false;

            //Eliminar la cabeza
            if(pos == 0)
            {
                if(cabeza == cola)
                {
                    cabeza = null;
                    cola = null;
                }
                else
                {
                    cabeza = cabeza.Siguiente;
                    cabeza!.Anterior = null;
                }
                return true;
            }

            //Eliminar la cola
            if(pos == tamanio -1)
            {
                cola = cola!.Anterior;
                cola!.Siguiente = null;
                return true;
            }
            //Eliminar posición intermedia
            Nodo? actual = cabeza;
            for (int i = 0; i < pos; i++)
            {
                actual = actual!.Siguiente;
            }
            actual!.Anterior!.Siguiente = actual.Siguiente;
            actual.Siguiente!.Anterior = actual.Anterior;
            return true;
        }
    }
}
