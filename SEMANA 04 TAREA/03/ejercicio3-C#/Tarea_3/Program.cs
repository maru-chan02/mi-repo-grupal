using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el peso en kg: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            //Calcula el IMC Usando la funcion de potencia 
            double imc = peso / Math.Pow(estatura, 2); //¿que valor se eleva al cuadrado?

            //Redondear a 2 decimales para mostrar 
            double imcRed = Math.Round(imc, 2); //Cantidad de decimales 

            Console.Write($"IMC: {imcRed}");

            //Clasificacion de rangos ( condicional multiples)
            if (imc < 18.5)
            {

                Console.WriteLine("Bajo de peso");
            }

            else if (imc < 25)
            {
                Console.WriteLine("Normal");

            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidad"); 
            }
        }
    }

}

        

        
  