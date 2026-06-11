namespace jp_11_p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo para guardar 5 códigos de productos.
            int[] codigos = new int[5];
            // Primer recorrido: registrar los códigos en el arreglo.
            for (int i = 0; i < codigos.Length; i++)
            {
                Console.Write($"Código {i + 1} : ");
                codigos[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Código a buscar: ");
            int buscado = int.Parse(Console.ReadLine());
            // Se inicia en - 1 porque todavía no se ha encontrado el código.
            // Si después de buscar sigue en - 1, significa que no existe.
            int posicion = -1;
            // Segundo recorrido: buscar el código dentro del arreglo.
            for (int i = 0; i < codigos.Length; i++)
            {
                // Comparamos el código actual con el código buscado.
                if (codigos[i] == buscado)
                {
                    // Guardamos el índice donde se encontró el código.
                    posicion = i;
                }
            }
            // Si posicion cambió, significa que el código fue encontrado.
            if (posicion != -1)
            {
                Console.WriteLine($"Código encontrado en índice {posicion} ");
            }
            else
            {
                Console.WriteLine("Código no encontrado");
            }
        }
    }
}
