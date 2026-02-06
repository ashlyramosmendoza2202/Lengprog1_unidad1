using System;

class Ejercicio18
{
    static void Main()
    {
        Console.WriteLine("Numero 1:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Numero 2:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Numero 3:");
        int n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 > n2  n1 > n3)
        {
            Console.WriteLine("El mayor es: " + n1);
        }
        else if (n2 > n3)
        {
            Console.WriteLine("El mayor es: " + n2);
        }
        else
        {
            Console.WriteLine("El mayor es: " + n3);
        }
    }
}
