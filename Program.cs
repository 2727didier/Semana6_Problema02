using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana6_Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacidadMaxima = 0;
            int asistentesActuales = 0;

            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Ingrese el número máximo de personas:");
            Console.Write("========================================\n");

            while (capacidadMaxima <= 0 || capacidadMaxima > 50)
            {
                if (int.TryParse(Console.ReadLine(), out capacidadMaxima) && capacidadMaxima > 0 && capacidadMaxima <= 50)
                {
                    Console.WriteLine($"El número máximo establecido es de {capacidadMaxima} personas.");
                    Console.WriteLine("Presione una tecla para comenzar a contar.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido entre 1 y 50.");
                    Console.Write("========================================\n");
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("| Asistentes actuales | " + asistentesActuales);
                Console.WriteLine("| Aforo               | " + (asistentesActuales * 100 / capacidadMaxima) + "%");
                Console.WriteLine("| Máximo              | " + capacidadMaxima + " personas");
                Console.WriteLine("=================================");
                Console.WriteLine("Presione");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");

                char opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case 'i':
                        if (asistentesActuales < capacidadMaxima)
                        {
                            asistentesActuales++;
                            Console.WriteLine("\nUna persona ha entrado al local.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nEl local está lleno. No se permite la entrada.");
                            Console.ReadKey();
                        }
                        break;

                    case 's':
                        if (asistentesActuales > 0)
                        {
                            asistentesActuales--;
                            Console.WriteLine("\nUna persona ha salido del local.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay personas en el local para que salgan.");
                            Console.ReadKey();
                        }
                        break;

                    case 'x':
                        Console.WriteLine("\nSaliendo del programa. ¡Gracias por usar el sistema de control de aforo!");
                        return;

                    default:
                        Console.WriteLine("\nOpción no válida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

}
    

