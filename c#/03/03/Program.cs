namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock = 500;
            int totalVendido = 0;

            Console.Write("Unidades vendidas (0 para salir): ");
            int venta = int.Parse(Console.ReadLine());

            
            while (venta != 0)               
            {
                
                if (venta < 0)             
                {
                    Console.WriteLine("Error: cantidad no puede ser negativa.");
                }
                
                else if (venta > stock)     
                {
                    Console.WriteLine($"Error: stock insuficiente. Quedan {stock}");
                }
                else
                {
                   
                    stock = stock - venta;        

                    
                    totalVendido = totalVendido + venta; 
                    Console.WriteLine($"Venta registrada. Stock: {stock}");
                }

                
                Console.Write("Unidades vendidas (0 para salir): ");
                venta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Stock restante: {stock}");
            Console.WriteLine($"Total vendido: {totalVendido}");
        }
    }
}
