using System;

class Ejercicio4Division
{
    static void Main()
    {
        Console.WriteLine("_________ Este es un Programa que Divide dos numeros _________");
        Console.WriteLine(" ");

        double PrimerValor;
        double SegundoValor;
        double Resultado;

        Console.WriteLine("Introduce el dividendo: ");
        PrimerValor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce el divisor: ");
        SegundoValor = Convert.ToDouble(Console.ReadLine());

        Resultado = PrimerValor / SegundoValor;

        Console.WriteLine("La division de " + PrimerValor + " / " + SegundoValor + " es " + Resultado);
    }
}