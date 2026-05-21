namespace Ejercicio_6
{
    internal class program
    {
        class Program
        {
            // Función para calcular el consumo mensual
            static double CalcularConsumo(int m3)
            {
                return m3 * 6.90;
            }

            // Función para calcular el costo total con IGV
            static double CalcularCosto(double consumo)
            {
                double igv = consumo * 0.18;
                double total = consumo + igv;

                return total;
            }

            // Procedimiento para mostrar el recibo
            static void MostrarRecibo(int m3, double consumo, double total)
            {
                Console.WriteLine("\n=== RECIBO DE AGUA ===");

                Console.WriteLine("Consumo en m3: " + m3);
                Console.WriteLine("Consumo mensual: S/ " + consumo.ToString("F2"));
                Console.WriteLine("Costo total con IGV: S/ " + total.ToString("F2"));
            }

            // Programa principal
            static void Main(string[] args)
            {
                Console.Write("Ingrese el consumo en m3: ");

                int m3 = int.Parse(Console.ReadLine());

                // Validación
                if (m3 >= 0)
                {
                    double consumo = CalcularConsumo(m3);

                    double total = CalcularCosto(consumo);

                    MostrarRecibo(m3, consumo, total);
                }
                else
                {
                    Console.WriteLine("Error: el consumo no puede ser negativo.");
                }
            }
        }
    }
}