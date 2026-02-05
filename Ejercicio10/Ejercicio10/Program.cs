using System;

class Ejercicio2
{
    static void Main()
    {
        Console.WriteLine("Escribe un numero:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            Console.WriteLine("Es positivo");
        }
        else if (n < 0)
        {
            Console.WriteLine("Es negativo");
        }
        else
        {
            Console.WriteLine("Es neutro");
        }
    }
}