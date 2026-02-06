using System;
class Ejercicio13
{
    static void Main()
    {
        Console.WriteLine("Inicio:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Final:");
        int b = Convert.ToInt32(Console.ReadLine());
        int i = a;
        while (i <= b)
        {
            Console.WriteLine(i);
            i = i + 1;
        }
    
