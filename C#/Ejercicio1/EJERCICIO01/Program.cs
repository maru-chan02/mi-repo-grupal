namespace EJERCICIO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad comprada: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio unitario: S/");
            double precioUnitario = double.Parse(Console.ReadLine());

            double subtotal = CalcularSubtotal(cantidad, precioUnitario);
            double igv = CalcularIGV(subtotal);
            double total = CalcularTotal(subtotal, igv);

            Console.WriteLine("\n=== BOLETA DE VENTA ===");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio unitario: S/{precioUnitario:F2}");
            Console.WriteLine($"Subtotal: S/{subtotal:F2}");
            Console.WriteLine($"IGV (18%): S/{igv:F2}");
            Console.WriteLine($"Total a pagar: S/{total:F2}");
        }

        static double CalcularSubtotal(int cantidad, double precioUnitario)
        {
            double subtotal = cantidad * precioUnitario;
            return subtotal;
        }

        static double CalcularIGV(double subtotal)
        {
            double igv = subtotal * 0.18;
            return igv;
        }

        static double CalcularTotal(double subtotal, double igv)
        {
            double total = subtotal + igv;
            return total;
        }
    }
}
