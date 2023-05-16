using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese las tres notas del alumno");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio final es: " + promedio.ToString("0.00"));
        }
    }
}