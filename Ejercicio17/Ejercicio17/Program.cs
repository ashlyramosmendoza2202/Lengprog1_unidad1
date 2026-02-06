using System;

class Ejercicio17
{
    static void Main()
    {
        Console.WriteLine("Escribe un numero:");
        int n = Convert.ToInt32(Console.ReadLine());
        int suma = 0;

        while (n > 0)
        {
            suma = suma + (n % 10);
            n = n / 10;
        }

        Console.WriteLine("La suma de sus digitos es: " + suma);
    }
}