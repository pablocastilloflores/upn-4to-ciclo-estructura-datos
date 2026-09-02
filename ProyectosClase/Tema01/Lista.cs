using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    internal class Lista
    {
        private Nodo? primero = new Nodo();
        private Nodo? ultimo = new Nodo();

        public Lista() {
            primero = null;
            ultimo = null;
        }
        public void insertarNodo(int valor)
        {
            if (buscarNodo(valor))
            {
                return;
            }
            Nodo? nuevo = new Nodo();
            nuevo.Dato = valor;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = primero;
            }   
            else
            {
                ultimo!.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }                  
        }
        public bool buscarNodo(int valor)
        {
            Nodo? actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                while (actual != null)
                {
                    if (actual.Dato == valor) return true;
                    else actual = actual.Siguiente;
                }
            }
            return false;
        }
        public bool modificarNodo(int anterior, int nuevo)
        {
            Nodo? actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                while (actual != null)
                {
                    if (actual.Dato == anterior)
                    {
                        actual.Dato = nuevo;
                        return true;
                    }
                    actual = actual.Siguiente;
                }
            }
            return false;
        }
        public bool mostrarLista(ListBox lista)
        {
            Nodo? actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                while (actual !=null)
                {
                    lista.Items.Add(actual.Dato);
                    actual = actual.Siguiente;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool eliminarNodo(int valor)
        {
            Nodo? actual = primero;
            Nodo? anterior = null;

            if (primero != null)
            {
                while(actual != null)
                {
                    if(actual.Dato == valor)
                    {
                        //Si ya encontró el dato
                        if(actual == primero) //Aquí eliminamos al primero
                        {
                            primero = primero.Siguiente;
                        }
                        else if(actual == ultimo) //Aquí eliminamos al último
                        {
                            anterior!.Siguiente = null;
                            ultimo = anterior;
                        }
                        else //Aquí eliminamos otro que no sea primero/ultimo
                        {
                            anterior!.Siguiente = actual.Siguiente;
                        }
                        return true;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                return false;
            }
            else return false;
        }
        public void ordenarLista()
        {
            if (primero != null)
            {
                int cantidadNodos = 1;
                Nodo? actual = primero;

                while (actual!.Siguiente != null)
                {
                    actual = actual.Siguiente;
                    cantidadNodos++;
                }

                int aux = 0;
                int t = 1;
                do
                {
                    actual = primero;
                    Nodo? siguiente = actual.Siguiente;

                    while (actual.Siguiente != null)
                    {
                        if(actual.Dato > siguiente!.Dato)
                        {
                            aux = actual.Dato;
                            actual.Dato = siguiente.Dato;
                            siguiente.Dato = aux;
                        }
                        actual = actual.Siguiente;
                        siguiente = siguiente?.Siguiente;
                    }
                    t++;
                } while (t <= cantidadNodos);                
            }
        }
    }
}

