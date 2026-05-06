namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000;
            int retiros = 0;

            Console.WriteLine("-Cajero Automático-");
            Console.WriteLine($"Saldo disponible: s/{saldo:F2}");

            Console.Write("Monto a retirar (0 para salir): ");
            double monto = double.Parse(Console.ReadLine());

            while (monto != 0)
            {
                if (monto < 0)
                {
                    Console.WriteLine("Error: monto inválido");
                }
                else if(monto > saldo)
                {
                    Console.WriteLine("Error: saldo insuficiente");
                }
                else
                {
                    saldo = saldo - monto;
                    retiros = retiros + 1;

                    Console.WriteLine($"Retiro exitoso - Saldo: S/{saldo:F2}");
                }

                Console.Write("Monto a retirar (0 para salir): ");
                monto = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("-Resumen-");
            Console.WriteLine($"Retiros realizados: {retiros}");
            Console.WriteLine($"Saldo Final: s/{saldo:F2}");


        }
    }
}
