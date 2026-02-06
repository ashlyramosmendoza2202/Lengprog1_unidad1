using System;

class Ejercicio14
{
    static void Main()
    {
        Console.WriteLine("Inicio:");
        int inicio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Final:");
        int final = Convert.ToInt32(Console.ReadLine());

        int suma = 0;

        for (int i = inicio; i <= final; i++)
        {
            suma = suma + i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}