using System;
class Ejercicio21
{
    static void Main()
    {
        Console.WriteLine("Cuantos numeros son?");
        int total = Convert.ToInt32(Console.ReadLine());
        double suma = 0;
        int i = 1;
        while (i <= total)
        {
            Console.WriteLine("Numero " + i + ":");
            suma = suma + Convert.ToDouble(Console.ReadLine());
            i = i + 1;
        }
        Console.WriteLine("Promedio: " + (suma / total));
    }
}