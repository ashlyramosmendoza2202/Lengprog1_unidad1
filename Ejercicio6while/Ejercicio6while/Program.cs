using System;

class Ejercicio6Pares
{
    static void Main()
    {
        Console.WriteLine("Numeros Pares del 1 al 100:");

        int i = 2;

        while (i <= 100)
        {
            Console.WriteLine(i);
            i = i + 2;
        }
    }
}