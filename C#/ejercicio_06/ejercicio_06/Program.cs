namespace ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votosAna = 0;
            int votosCarlos = 0;
            int votosLucia = 0;
            int nulos = 0;
            int voto;

            do
            {
                Console.WriteLine("\n=== SISTEMA DE VOTACIÓN ===");
                Console.WriteLine("1. Ana Torres");
                Console.WriteLine("2. Carlos Mendoza");
                Console.WriteLine("3. Lucía Paredes");
                Console.WriteLine("0. Cerrar votación");
                Console.Write("Ingrese su voto: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    votosAna = votosAna + 1;
                    Console.WriteLine("Voto registrado para Ana Torres.");
                }
                else if (voto == 2)
                {
                    votosCarlos = votosCarlos + 1;
                    Console.WriteLine("Voto registrado para Carlos Mendoza.");
                }
                else if (voto == 3)
                {
                    votosLucia = votosLucia + 1;
                    Console.WriteLine("Voto registrado para Lucía Paredes.");
                }
                else if (voto != 0)
                {
                    nulos = nulos + 1;
                    Console.WriteLine("Voto nulo.");
                }
            } while (voto != 0);

            int total = votosAna + votosCarlos + votosLucia + nulos;

            Console.WriteLine("\n=== RESULTADOS ===");
            Console.WriteLine($"Ana Torres: {votosAna}");
            Console.WriteLine($"Carlos Mendoza: {votosCarlos}");
            Console.WriteLine($"Lucía Paredes: {votosLucia}");
            Console.WriteLine($"Votos nulos: {nulos}");
            Console.WriteLine($"Total de votantes: {total}");

            if (votosAna > votosCarlos && votosAna > votosLucia)
            {
                Console.WriteLine("Ganadora: Ana Torres");
            }
            else if (votosCarlos > votosAna && votosCarlos > votosLucia)
            {
                Console.WriteLine("Ganador: Carlos Mendoza");
            }
            else if (votosLucia > votosAna && votosLucia > votosCarlos)
            {
                Console.WriteLine("Ganadora: Lucía Paredes");
            }
            else
            {
                Console.WriteLine("Resultado: EMPATE");
            }
        }
    }
}
