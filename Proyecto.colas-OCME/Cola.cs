using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto.colas_OCME
{
    internal class Cola
    {
        private Nodo inicio;
        private int count = 0;
        private int MAX;
        public Cola(int max)
        {
            MAX = max;
            inicio = null;
        }
        private bool UnderFlow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }
        private bool OverFlow()
        {
            if (count == MAX)
                return true;
            else
                return false;
        }
        public void print()
        {
            if (UnderFlow())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Nodo temp = inicio;
            Console.WriteLine("Elementos en la cola:");
            while (temp != null)
            {
                Console.Write(temp.Valor + " ");
                temp = temp.Sig;
            }
            Console.WriteLine();
        }
    

        public int Count()
        {
            int contador = 0;
            for (Nodo Inodo = inicio; Inodo != null; Inodo = Inodo.Sig)
            {
                contador++;
            }
            return contador;
        }

        public bool Insert(int num)
        {
            //Regresa true al insertar exitosamente
            //regresara false si la cola esta llena y no se pudo insertar

            if (OverFlow())
            {
                Console.WriteLine("La cola está llena.");
                return false;
            }

            Nodo nuevoNodo = new Nodo(num);

            // Si la cola está vacía, el nuevo nodo será el primero
            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                // Si la cola no está vacía, el nuevo nodo será añadido al final de la cola
                Nodo temp = inicio;
                while (temp.Sig != null)
                {
                    temp = temp.Sig;
                }
                temp.Sig = nuevoNodo;
            }

            count++;
            Console.WriteLine($"Elemento {num} insertado.");
            return true;
        }

    

        public int Extract()
        {
        //regresara el valor extraido de la cola
        //si la cola esta vacia regresa -1, por que no pudo extraer
            if (UnderFlow())
                 {
                 Console.WriteLine(" La cola está vacía.");
                  return -1; // No extraido
                 }
                
                // extraera el primer numero de la cola
            int valorExtraido = inicio.Valor;
         inicio = inicio.Sig;

         count--;
         Console.WriteLine($"Elemento {valorExtraido} Extraido.");
         return valorExtraido;
    
        }
    }
}
