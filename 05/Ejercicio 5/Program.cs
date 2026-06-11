using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
            int diaEncontrado = -1;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Ingrese temperatura del día {i + 1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > 30 && diaEncontrado == -1)
                {
                    diaEncontrado = i;
                }
            }

            if (diaEncontrado != -1)
            {
                Console.WriteLine($"Primera alerta en día {diaEncontrado + 1}");
            }
            else
            {
                Console.WriteLine("No hubo alerta de temperatura");
            }
        }
    }
}
