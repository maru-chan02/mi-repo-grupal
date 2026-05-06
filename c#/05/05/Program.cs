namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Depósito inicial: S/");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Meta a alcanzar: S/");
            double meta = double.Parse(Console.ReadLine());

            
            double tasa = 0.015;
            int meses = 0;

            Console.WriteLine($"Mes 0: S/{saldo:F2}");

            
            while (saldo < meta)
            {
                saldo = saldo * (1 + tasa);  
                meses = meses + 1;           

                Console.WriteLine($"Mes {meses}: S/{saldo:F2}");
            }

            Console.WriteLine($"\nAlcanzará la meta en {meses} meses.");
        }
    }
}
