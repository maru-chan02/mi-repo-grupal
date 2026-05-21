class Program
{
    // Variables estáticas: representan reglas generales del programa
    static double tipoCambio = 3.75;
    static double porcentajeComision = 0.02;

    static void Main(string[] args)
    {
        Console.WriteLine("=== CASA DE CAMBIO ===");
        Console.Write("Ingrese monto en soles: S/");

        double soles = double.Parse(Console.ReadLine());

        double comision = CalcularComision(soles);
        double solesNetos = CalcularSolesNetos(soles, comision);
        double dolares = ConvertirADolares(solesNetos);

        MostrarComprobante(soles, comision, solesNetos, dolares);
    }

    // Calcula la comisión del 2 %
    static double CalcularComision(double soles)
    {
        double comision = soles * porcentajeComision;
        return comision;
    }

    // Calcula el monto disponible luego de descontar la comisión
    static double CalcularSolesNetos(double soles, double comision)
    {
        double solesNetos = soles - comision;
        return solesNetos;
    }

    // Convierte soles netos a dólares
    static double ConvertirADolares(double solesNetos)
    {
        double dolares = solesNetos / tipoCambio;
        return dolares;
    }

    // Método void: muestra el comprobante final
    static void MostrarComprobante(double soles, double comision, double solesNetos, double dolares)
    {
        Console.WriteLine("\n=== COMPROBANTE ===");

        Console.WriteLine($"Monto ingresado: S/ {soles:F2}");
        Console.WriteLine($"Comisión (2%): S/ {comision:F2}");
        Console.WriteLine($"Soles netos a cambiar: S/ {solesNetos:F2}");
        Console.WriteLine($"Dólares recibidos: $ {dolares:F2}");
    }
}