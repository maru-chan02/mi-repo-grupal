namespace tarea_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un arreglo para guardar 3 nombres
            string[] estudiantes = new string[3];

            //Registra nombres en el arreglo 
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($" Nombre del estudiante {i + 1}: ");
                estudiantes[i] = Console.ReadLine();            
            }
            Console.WriteLine();
            Console.WriteLine("Estudiantes registrados : ");

            // Mostrar los registrar los nombres de los estudiantes 
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {estudiantes[i]}");
            }
        }
    }
}
    
