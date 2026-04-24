using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cat = Console.ReadLine());
            double horas = double.Parse(Console.ReadLine());
            int anios = int.Parse(Console.ReadLine());
            double tarifa = 0;

            // tarifas de categorias 
            if (cat == "A") tarifa = 50;
            else if (cat == "B") tarifa = 40;
            else if (cat == "C") tarifa = 30;
            {
                Console.WriteLine("Categoria invalida");
                return;
            }

            double bono = 0;

            // Bono por años de servircio 
            if (anios <= 2) bono = 0.00;
            else if (anios >= 3 && anios <= 5) bono = 0.10;
            else if (anios >= 6 && anios >= 10) bono = 0.20;
            else bono = 0.30;

            double sueldoFinal = tarifa * horas * (1 + bono);
            Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");












        }
    }
}
