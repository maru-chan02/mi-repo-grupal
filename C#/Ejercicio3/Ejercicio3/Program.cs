using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static double CalcularBruto(double horas)
        {
            return horas * 12.50;
        }
        static double CalcularDescuento(double bruto)
        {
            return bruto * 0.05;
        }
        static double CalcularNeto(double bruto, double descuento)
        {
            return bruto - descuento;
        }
        static void Main(string[] args)
        {
            Console.Write("Horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());

            double bruto = CalcularBruto(horas);
            double descuento = CalcularDescuento(bruto);
            double neto = CalcularNeto(bruto, descuento);
            Console.WriteLine("\n=== BOLESTA DE SUELDO ===");
            Console.WriteLine($"Sueldo bruto: S/ {bruto:F2}");
            Console.WriteLine($"Descuento (5%): S/ {descuento:F2}");
            Console.WriteLine($"Sueldo neto: S/ {neto:F2}");
        }
    }
}
