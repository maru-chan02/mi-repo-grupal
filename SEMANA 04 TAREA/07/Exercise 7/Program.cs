using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la nota de la práctica 1: ");
            double pc01 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota de la práctica 2: ");
            double pc02 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota de la práctica 3: ");
            double pc03 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota del examen parcial: ");
            double ep = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota del examen final: ");
            double ef = double.Parse(Console.ReadLine());

            double menor = Math.Min(pc01, Math.Min(pc02, pc03));

            double prom_pr = (pc01 + pc02 + pc03 - menor) / 2;

            double prom_f = (ep + ef + prom_pr) / 3;

            Console.WriteLine("Promedio de prácticas: " + prom_pr);
            Console.WriteLine("Promedio final: " + prom_f);

            if (prom_f >= 18)
            {
                Console.WriteLine("Excelente");

            }

            else if (prom_f >= 14)
            {
                Console.WriteLine("Bueno");

            }

            else if (prom_f >= 10)
            {
                Console.WriteLine("Regular");

            }

            else
            {
                Console.WriteLine("Deficiente");

            }


        }
    }
}
