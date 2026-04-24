using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto de la compra: ");
            double monto = double.Parse(Console.ReadLine());
            double descuento = 0;

            if (monto >= 100)
            {
                descuento = monto * 0.10;
            }
            double total = monto - descuento;
            Console.WriteLine($"Descuento aplicado: S/ {descuento:F2}");
            Console.WriteLine($"Total a pagar: S/ {total:F2}");

        }
    }
}
