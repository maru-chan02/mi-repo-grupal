using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] precios = new double[5];
            double buscado, nuevo;
            int posicion = -1;

            for (int i = 0; i < precios.Length; i++)
            {
                Console.Write($"Precio {i + 1}: ");
                precios[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Precio a buscar: ");
            buscado = double.Parse(Console.ReadLine());

            for (int i = 0; i < precios.Length; i++)
            {
                if (precios[i] == buscado)
                {
                    posicion = i;
                }
            }

            if (posicion != -1)
            {
                Console.Write("Nuevo precio: ");
                nuevo = double.Parse(Console.ReadLine());

                precios[posicion] = nuevo;
                Console.WriteLine("Precio actualizado");
            }
            else
            {
                Console.WriteLine("Precio no encontrado");
            }

            Console.WriteLine("\nLista de precios:");

            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {precios[i]}");
            }
        }
    }
}
