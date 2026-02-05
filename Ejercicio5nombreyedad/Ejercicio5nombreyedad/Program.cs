using System;

class Ejercicio5Edad
{
    static void Main()
    {
        Console.WriteLine("_________ Programa de Verificacion de Edad _________");
        Console.WriteLine(" ");

        string Nombre;
        int Edad;

        Console.WriteLine("Introduce tu nombre: ");
        Nombre = Console.ReadLine();

        Console.WriteLine("Introduce tu edad: ");
        Edad = Convert.ToInt32(Console.ReadLine());

        if (Edad >= 18)
        {
            Console.WriteLine(Nombre + " es adulto.");
        }
        else
        {
            Console.WriteLine(Nombre + " es menor de edad.");
        }
    }
}