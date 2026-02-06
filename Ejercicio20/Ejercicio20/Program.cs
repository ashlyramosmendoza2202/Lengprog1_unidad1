using System;
class Ejercicio20
{
    static void Main()
    {
        Console.WriteLine("Numero:");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(n + "x" + i + "=" + (n * i));
            i = i + 1;
        }
    }
}


