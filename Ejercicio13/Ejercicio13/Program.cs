using System;
class Ejercicio13
{
    static void Main()
    {
        Console.WriteLine("Inicio:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Final:");
        int b = Convert.ToInt32(Console.ReadLine());
        int final = Convert.ToInt32(Console.ReadLine());

        int suma = 0;

       for(int i = inicio; i <= final; i++)
        {
            suma = suma + i;
        }

        Console.WriteLine("La suma es: " + suma);


