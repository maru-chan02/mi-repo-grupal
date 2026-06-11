namespace ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] asistencia = new int[5];

            // 1. Registrar asistencia
            Console.WriteLine("=== Registro de Asistencia ===");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese asistencia sesión {i}: ");
                asistencia[i] = int.Parse(Console.ReadLine());
            }

            // 2. Mostrar todas las asistencias
            Console.WriteLine("\n=== Asistencias Registradas ===");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Sesión {i}: {asistencia[i]}");
            }

            // 3. Verificar si alguna sesión tuvo 0 asistentes
            bool existeCero = false;
            for (int i = 0; i < 5; i++)
            {
                if (asistencia[i] == 0)
                    existeCero = true;
            }

            if (existeCero)
                Console.WriteLine("\nAlerta: existe una sesión con 0 asistentes");
            else
                Console.WriteLine("\nNo hay sesión con 0 asistentes");

            // 4. Modificar una asistencia por índice
            Console.Write("\nIngrese índice a modificar (0-4): ");
            int indiceModificar = int.Parse(Console.ReadLine());

            if (indiceModificar >= 0 && indiceModificar < 5)
            {
                Console.Write("Ingrese nuevo valor: ");
                int nuevoValor = int.Parse(Console.ReadLine());
                asistencia[indiceModificar] = nuevoValor;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }

            // 5. Mostrar asistencias actualizadas
            Console.WriteLine("\n=== Asistencias Actualizadas ===");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Sesión {i}: {asistencia[i]}");
            }
        }
    }
}
