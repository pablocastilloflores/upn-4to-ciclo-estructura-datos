using System;


namespace ListasCirculares
{
    internal class ListaCircular
    {
        public Nodo? Cabeza { get; set; }
        public Nodo? Cola { get; set; }
        public ListaCircular()
        {
            Cabeza = null;
            Cola = null;
        }
        //Insertar al inicio
        public void insertarInicio(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if(Cabeza == null)
            {
                Cabeza = nuevo;
                Cola = nuevo;

                Cabeza.Anterior = Cola;
                Cola.Siguiente = Cabeza;
            }
            else
            {
                nuevo.Siguiente = Cabeza;
                Cabeza.Anterior = nuevo;
                nuevo.Anterior = Cola!;
                Cola!.Siguiente = nuevo;
                Cabeza = nuevo;
            }
        }
        //insertar al final
        public void insertarFinal(int valor)
        {
            Nodo? nuevo = new Nodo(valor);

            if (Cabeza == null)
            {
                Cabeza = nuevo;
                Cola = nuevo;

                Cabeza.Anterior = Cola;
                Cola.Siguiente = Cabeza;
            }
            else
            {
                Cola!.Siguiente = nuevo;
                nuevo.Anterior = Cola!;
                nuevo.Siguiente = Cabeza;
                Cabeza.Anterior = nuevo;
                Cola = nuevo;
            }
        }
        public bool Eliminar(int valor)
        {
            Nodo? actual = Cabeza;
            Nodo? anterior = Cola;
            bool encontrado = false;

            do
            {
                if(actual!.Valor == valor)
                {
                    encontrado = true;
                    break;
                }
                anterior = actual;
                actual = actual.Siguiente;                
            } while (actual != Cabeza);

            if (!encontrado) return false;

            //1. Único nodo en la lista.
            if(Cabeza == Cola && actual == Cabeza)
            {
                Cabeza = null;
                Cola = null;
                return true;
            }
            //2. Es la cabeza
            else if(actual == Cabeza)
            {
                Cabeza = Cabeza!.Siguiente;
                Cabeza!.Anterior = Cola;
                Cola!.Siguiente = Cabeza;
            }
            //3. Es la cola
            else if(actual == Cola)
            {
                Cola = Cola!.Anterior;
                Cola!.Siguiente = Cabeza;
                Cabeza!.Anterior = Cola;
            }
            //4. Nodo intermedio
            else
            {
                actual!.Anterior = actual.Siguiente;
                actual.Siguiente!.Anterior = actual.Anterior;
            }
            return true;
        }
    }
}
