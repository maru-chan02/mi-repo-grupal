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
            Console.WriteLine("Ingrese el codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            int digitos = 0;
            
            if (codigo == 0)
            {
                digitos = 1;
            }
            else
            {
                while(codigo > 0)
                {
                    digitos++;
                    codigo /= 10;
                } 
            }
            if (digitos >= 6 && digitos <= 8)
            {
                Console.WriteLine("Codigo valido");
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }
        }
    }
}
