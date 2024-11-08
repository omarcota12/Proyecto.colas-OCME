using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.colas_OCME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TCola = 0;
            Cola cola = null;
            int opcion;
            do
            {

                // Menú de selección
                Console.WriteLine("Menu Pilas");
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|1.- establecer tamaño            |");
                Console.WriteLine("|2.- Insert                       |");
                Console.WriteLine("|3.- Extract                      |");
                Console.WriteLine("|4.- Imprimir                     |");
                Console.WriteLine("|5.- Salir                        |");
                Console.WriteLine("|Seleccionar opcion =>            |");
                Console.WriteLine("|---------------------------------|");

                // Validación de la opción ingresada
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 5.");
                    Console.Write("Seleccione una opción: ");
                }

                switch (opcion)//switch de casos
                {

                    case 1: // establecer tamaño
                        Console.Write("Ingrese el tamaño maximo de la cola: ");
                        while (!int.TryParse(Console.ReadLine(), out TCola) || TCola <= 0)
                        {
                            Console.WriteLine("El numero debe ser mayor a 0");
                        }
                        cola = new Cola(TCola);
                        Console.WriteLine($"Tamaño de la cola establecido a {TCola}.");

                        break;
                    case 2: // Insert
                        if (cola == null)
                        {
                            Console.WriteLine("favor de establecer el tamaño");
                        }
                        else
                        {
                            Console.Write("Ingrese el numero a insertar: ");
                            int numInsertar;
                            while (!int.TryParse(Console.ReadLine(), out numInsertar))
                            {
                                Console.WriteLine("Numero no valido intentelo de nuevo");
                            }
                            cola.Insert(numInsertar);
                        }
                        break;
                    case 3: // Extract
                        if (cola == null)
                        {
                            Console.WriteLine("Debe establecer el tamaño de la cola primero.");
                        }
                        else
                        {
                            cola.Extract();
                        }
                        break;
                    case 4: // imprimir

                        if (cola == null)
                        {
                            Console.WriteLine("Debe establecer el tamaño de la cola primero.");
                        }
                        else
                        {
                            cola.print();
                        }
                        break;
                    case 5: // Salir
                        Console.WriteLine("Saliendo del programa.");
                        break;
                        
                }
                Console.WriteLine();
            } while (opcion != 5); // Salir si se termina el programa
        }
    }
}
