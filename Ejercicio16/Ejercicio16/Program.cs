using System;

class Ejercicio16
{
    static void Main()
    {
        Console.WriteLine("Escribe un numero:");
        string texto = Console.ReadLine();
        string alReves = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            alReves = alReves + texto[i];
        }

        if (texto == alReves)
        {
            Console.WriteLine("Es capicua");
        }
        else
        {
            Console.WriteLine("No es capicua");
        }
    }
}