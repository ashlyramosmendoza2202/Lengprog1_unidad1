using System;

class Ejercicio12
{
    static void Main()
    {
        Console.WriteLine("Escribe un numero:");
        int num = Convert.ToInt32(Console.ReadLine());

        int contador = 0;
        int i = 1;

        while (i <= num)
        {
            if (num % i == 0)
            {
                contador = contador + 1;
            }
            i = i + 1; 
        }

        if (contador == 2)
        {
            Console.WriteLine("Es perfecto");
        }
        else
        {
            Console.WriteLine("No es perfecto");
        }
    }
}
