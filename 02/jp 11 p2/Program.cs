namespace jp_11_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de estudiantes: ");
            int n = int.Parse(Console.ReadLine());
            // El arreglo tendrá tantas posiciones como estudiantes indique el usuario.
            double[] notas = new double[n];
            // Acumulador para sumar todas las notas y luego calcular el promedio.
            double suma = 0;
            // Primer recorrido: registrar notas y acumular la suma.
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Nota {i + 1} : ");
                notas[i] = double.Parse(Console.ReadLine());
                suma = suma + notas[i];
            }
            // Se toma la primera nota como referencia inicial.
            // Luego se compara con las demás notas.
            double minima = notas[0];
            double maxima = notas[0];
            // Segundo recorrido: buscar la nota mínima y máxima.
            // Se empieza en 1 porque la posición 0 ya fue usada como referencia.
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
            }
            Console.WriteLine($"Promedio: {suma / n:F2} ");
            Console.WriteLine($"Nota mínima: {minima:F2} ");
            Console.WriteLine($"Nota máxima: {maxima:F2} ");
        }
    
    }
}
