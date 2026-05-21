using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        const double TIPO_CAMBIO = 3.75;
        const double PORCENTAJE_COMISION = 0.02;
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto en soles (S/): ");
            double solesIngresados = Convert.ToDouble(Console.ReadLine());

            double comision = CalcularComision(solesIngresados);
            double montoNeto = CalcularMontoNeto(solesIngresados, comision);
            double dolaresRecibidos = ConvertirADolares(montoNeto);

            MostrarComprobante(solesIngresados, comision, montoNeto, dolaresRecibidos);
        }

        static double CalcularComision(double soles)
        {
            return soles * PORCENTAJE_COMISION;
        }

        static double CalcularMontoNeto(double soles, double comision)
        {
            return soles - comision;
        }

        static double ConvertirADolares(double montoNetoSoles)
        {
            return montoNetoSoles / TIPO_CAMBIO;
        }

        static void MostrarComprobante(double inicial, double comision, double neto, double dolares)
        {
            Console.WriteLine("\n=======================================");
            Console.WriteLine("          COMPROBANTE DE PAGO          ");
            Console.WriteLine("=======================================");
            Console.WriteLine($"Monto original en Soles : S/ {inicial:N2}");
            Console.WriteLine($"Comisión cobrada (2%)   : S/ {comision:N2}");
            Console.WriteLine($"Monto neto en Soles     : S/ {neto:N2}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Tipo de cambio aplicado : S/ {TIPO_CAMBIO:N2} por $1");
            Console.WriteLine($"Dólares recibido     : $ {dolares:N2}");
            Console.WriteLine("=======================================\n");
        }
    }
}
