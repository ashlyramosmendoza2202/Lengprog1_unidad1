using System;

class ProgramaResta
{
    static void Main()
    {
       
        Console.WriteLine("---------------- Operacion de Resta ----------------");
        Console.WriteLine(" ");

        int valorA;
        int valorB;
        int resultado;

        Console.WriteLine("Ingrese el primer numero entero: ");
        valorA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero entero: ");
        valorB = Convert.ToInt32(Console.ReadLine());

       
        resultado = valorA - valorB;

    
        Console.WriteLine(" ");
        Console.WriteLine("El resultado de restar " + valorA + " menos " + valorB + " es: " + resultado);

  
        Console.ReadKey();
    }
}
