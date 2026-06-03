using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_10_p
{
    internal class Program
    {
        static double ObtenerTarifa(int opcion)
        {
            if (opcion == 1)
            {
                return 30;
            }
            else if (opcion == 2)
            {
                return 60;
            }
            else if (opcion == 3)
            {
                return 90;
            }
            else
            {
                return 0;
            }
        }
           
        static void Main(string[] args)
        {
                Console.WriteLine("=== SERVICIO TÉCNICO ===");
                Console.WriteLine("1. Diagnóstico - S/30");
                Console.WriteLine("2. Mantenimiento - S/60");
                Console.WriteLine("3. Reparación - S/90");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());
                // Obtenemos la tarifa según la opción elegida.
                double tarifa = ObtenerTarifa(opcion);
                // Si la tarifa es 0, la opción no existe.
                if (tarifa == 0)
                {
                    Console.WriteLine("Datos no válidos.");
                    return; // Termina el programa y no pide cantidad.
                }
                // Solo si la opción fue válida, pedimos la cantidad.
                Console.Write("Cantidad de equipos: ");
                int cantidad = int.Parse(Console.ReadLine());
                // La cantidad debe ser mayor que 0.
                if (cantidad > 0)
                {
                    double total = tarifa * cantidad;
                    Console.WriteLine($"Total a pagar: S/ {total:F2} ");
                }
                else
                {
                    Console.WriteLine("Datos no válidos.");

                }
        }
        
    }

}