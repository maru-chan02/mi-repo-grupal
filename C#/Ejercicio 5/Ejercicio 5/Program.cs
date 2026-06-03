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
            double sumaPorcentajes = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"\nSesion {i}");
                Console.WriteLine("Ingrese la cantidad de asistentes: ");
                double asistentes = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de matriculados: ");
                double matriculados = double.Parse(Console.ReadLine());

                double porcentaje = (asistentes / matriculados) * 100;
                sumaPorcentajes += porcentaje;
            }

            double promedio = sumaPorcentajes / 4;
            Console.WriteLine($"\nPromedio de asistencia: {promedio:F2}%");

            if (promedio >= 75)
            {
                Console.WriteLine("Participación adecuada");
            }
            else
            {
                Console.WriteLine("Reforzar asistencia");
            }
        }
    }
}
