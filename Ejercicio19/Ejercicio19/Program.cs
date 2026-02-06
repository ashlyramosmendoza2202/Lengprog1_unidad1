

using System;

class Ejercicio19
{
    static void Main()
    {
        Console.WriteLine("Cuantos numeros quieres?");
        int limite = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;
        int i = 1;

        while (i <= limite)
        {
            Console.WriteLine(a);

            int suma = a + b;
            a = b;
            b = suma;

            i = i + 1;
        }
    }
}


