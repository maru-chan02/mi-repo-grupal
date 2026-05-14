namespace ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            do
            {
                Console.Write("Ingrese nota (0-20): ");
                nota = int.Parse(Console.ReadLine());

                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("Error: nota debe ser entre 0 y 20.");
                }
            } while (nota < 0 || nota > 20);

            if (nota >= 18)
            {
                Console.WriteLine("Clasificación: EXCELENTE");
            }
            else if (nota >= 14)
            {
                Console.WriteLine("Clasificación: BUENO");
            }
            else if (nota >= 11)
            {
                Console.WriteLine("Clasificación: REGULAR");
            }
            else
            {
                Console.WriteLine("Clasificación: DESAPROBADO");
            }
        }
    }
}
