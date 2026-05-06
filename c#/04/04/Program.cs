namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secreto = rand.Next(1, 51);   

            int intentos = 0;
            int maxIntentos = 7;
            bool adivino = false;

            Console.WriteLine("Adivina el número entre 1 y 50. Tienes 7 intentos.");

            
            while (intentos < maxIntentos && adivino == false)
            {
                intentos++;  

                Console.Write($"Intento {intentos}: ");
                int intento = int.Parse(Console.ReadLine());

                if (intento == secreto)
                {
                    adivino = true;           
                }
                else if (intento < secreto)   
                {
                    Console.WriteLine("El número secreto es MAYOR.");
                }
                else
                {
                    Console.WriteLine("El número secreto es MENOR.");
                }
            }

            
            if (adivino)
            {
                Console.WriteLine($"¡Ganaste! Adivinaste en {intentos} intento(s).");
            }
            else
            {
                Console.WriteLine($"¡Perdiste! El número secreto era {secreto}.");
            }
        }
    }
}
