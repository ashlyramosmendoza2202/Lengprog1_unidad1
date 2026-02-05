using System;

class Ejercicio8
{
    static void Main()
    {
        Console.WriteLine("Pon un numero:");

        int n;
        n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Es par");
        }
        else
        {
            Console.WriteLine("Es impar");
        }
    }
}k
