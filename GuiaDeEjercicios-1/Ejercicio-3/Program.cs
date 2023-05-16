using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int añoActual, añoDeNacimiento, edad;

            Console.WriteLine("Ingrese el año actual");
            añoActual = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año de nacimiento");
            añoDeNacimiento = int.Parse(Console.ReadLine());

            edad = añoActual - añoDeNacimiento;

            Console.WriteLine("La edad de la persona es: " + edad + " años");
        }
    }
}
