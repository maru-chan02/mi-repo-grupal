using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static double CalcularSalario(double valorHora, int horas)
        {
            // Si no supera 192 horas, todo se paga normal.
            if (horas <= 192)
            {
                return valorHora * horas;
            }
            // Si supera 192 horas, calculamos horas extra.
            int horasExtra = horas - 192;

            double pagoNormal = valorHora * 192;
            // las horas extra se pagan al 150% del valor normal.
            double pagoExtra = horasExtra * valorHora * 1.5;
            return pagoNormal + pagoExtra;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== PLANILLA INDUSTRIAL ===");
            Console.Write("Cantidad de obreros: ");
            int n = int.Parse(Console.ReadLine());
            // Acumulador del total de salarios.
            double totalPlanilla = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nObrero {i}");
                Console.Write("Valor por hora: S/");
                double vh = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                int hmt = int.Parse(Console.ReadLine());
                // Llamamos a la función para calcular el salario.
                double salario = CalcularSalario(vh, hmt);
                // Acumulamos el salario de cada obrero.
                totalPlanilla = totalPlanilla + salario;
                Console.WriteLine($"Salario: S/ {salario:F2}");
            }
            Console.WriteLine($"\nTotal de planilla: S/ {totalPlanilla:F2}");
        }
    }
}
