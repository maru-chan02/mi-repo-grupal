using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejecicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su promedio:");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 15 && nota <= 20)
                Console.WriteLine("excelente");
            else if (nota >= 11 && nota < 14)
                Console.WriteLine("bueno");
            else if (nota < 10 && nota >= 6)
                Console.WriteLine("regular");
            else if (nota < 5 && nota >= 0)
                Console.WriteLine("definiendo");
            else
                Console.WriteLine("valor invalido");
                
        }
    }
}
