using System;
class Ejercicio22
{
    static void Main()
    {
        Console.WriteLine("Año:");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 4 == 0) { Console.WriteLine("Si es bisiesto"); }
        else { Console.WriteLine("No es bisiesto"); }
    }
}