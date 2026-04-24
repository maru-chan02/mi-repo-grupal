using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu de operaciones ===");
            Console.WriteLine("1. Calcular area de un circulo");
            Console.WriteLine("2. Calcular area de un cuadrado");
            Console.WriteLine("3. Calcular area de un triangulo");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opcion (1-4): ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Area circulo = pi * r^2");
                    break;
                case 2:
                    Console.WriteLine("Area cuadrado = lado^2");
                    break;
                case 3:
                    Console.WriteLine("Area triangulo = (base * altura) / 2");
                    break;
                case 4:
                    Console.WriteLine("Saliendo del pograma...");
                    break;
                default:
                    Console.WriteLine("Opcione invalida. Ingresa un numero del 1 al 4");
                    break;
            }
        }
    }
}
