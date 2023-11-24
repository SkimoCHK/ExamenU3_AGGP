using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3_AGGP.Clases
{
    public class ListaEnlazada
    {
        Nodo primerNodo;

        public void ListaVacia()
        {
            primerNodo = null;
        }
        public bool ComprobarLista()
        {
            return primerNodo == null ? true : false;
        }

        public void InsertarAlFinal(Persona personas)
        {
            Nodo nodoNuevo = new Nodo(personas);
            if (ComprobarLista())
            {
                
                primerNodo = nodoNuevo;
                return;
            }
            Nodo nodoActual = primerNodo;
            while(nodoActual._siguiente != null)
            {
                nodoActual = nodoActual._siguiente;
            }

            nodoActual._siguiente = nodoNuevo;

        }
        public void ImprimirPersonas()
        {
            Nodo nodoActual = primerNodo;
            int i = 1;
            Console.WriteLine("Personas desordenadas");
            while(nodoActual != null)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Persona{i}");
                Console.WriteLine($"Nombre:{nodoActual._persona.Nombre} ");
                Console.WriteLine($"Edad:{nodoActual._persona.Edad}");
                Console.WriteLine("------------------------");
                Console.WriteLine();
                nodoActual = nodoActual._siguiente;
                i++;
            }

        }

        

        public void BuscarPersona(Persona persona)
        {
            if (ComprobarLista())
            {
                Console.WriteLine("La lista ta vacía mi lider");
                return;
            }
            Nodo nodoActual = primerNodo;
            int contador = 1;
            while(nodoActual != null && nodoActual._persona.Nombre != persona.Nombre)
            {
                contador++;
                nodoActual = nodoActual._siguiente;
            }
            if (nodoActual == null)
            {
                Console.WriteLine("La persona no existe en la lista!");
                return;
            }

            Console.WriteLine($"La persona existe en la posicion {contador} de la lista!");


        }
        public void ImprimirAscendente(Persona persona)
        {

        }

        public void OrdenarAscendente()
        {



        }
        


    }
}
