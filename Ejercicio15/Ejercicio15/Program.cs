using System;

class Ejercicio15
{
    static void Main()
    {
        Console.WriteLine("Dime un numero:");
        int n = Convert.ToInt32(Console.ReadLine());

        long f = 1;

        for (int i = 1; i <= n; i++)
        {
            f = f * i;
        }

        Console.WriteLine("El factorial es: " + f);
    }
}