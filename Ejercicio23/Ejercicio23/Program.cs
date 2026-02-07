using System;
class Ejercicio16
{
    static void Main()
    {
        Console.WriteLine("Escribe algo:");
        string t = Console.ReadLine();
        string res = "";
        int i = t.Length - 1;
        while (i >= 0)
        {
            res = res + t[i];
            i = i - 1;
        }
        Console.WriteLine("Reves: " + res);
    }
}