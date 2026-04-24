using System;
class Programa
{
    static void Main()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Puedes pasar, eres mayor de edad.");
        }
        else
        {
            int faltan = Math.Abs(18 - edad);
            Console.WriteLine("No puedes pasar, eres menor de edad.");
            Console.WriteLine("Te faltan " + faltan + " año(s) para ser mayor de edad.");
        }
    }
}