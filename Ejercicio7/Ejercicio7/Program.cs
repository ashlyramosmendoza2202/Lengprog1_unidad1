using System;

class Ejercicio7Impares
{
    static void Main()
    {
        Console.WriteLine("Numeros Impares del 1 al 100:");

        int i = 1;

        while (i <= 100)
        {
            Console.WriteLine(i);
            i = i + 2;
        }
    }
}