using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static double notaAprobatoria = 11;
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double promedio = CalcularPromedio(nota1, nota2, nota3);
            string estado = ClasificarEstudiante(promedio);
            MostrarReporte(promedio, estado);

        }
        static double CalcularPromedio(double n1, double n2, double n3)
        {
            double promedio = (n1 + n2 + n3) / 3;
            return promedio;
        }
        static string ClasificarEstudiante(double promedio)
        {
            if(promedio >= notaAprobatoria)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }
        }
        static void MostrarReporte(double promedio, string estado)
        {
            Console.WriteLine("\n=== REPORTE DE NOTAS ===");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Estado: {estado}");
        }
    }
}
