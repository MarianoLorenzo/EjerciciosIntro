using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, suma, resta, multiplicacion, division;

            Console.WriteLine("Ingrese dos números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            suma = n1 + n2;
            resta = n1 - n2;
            multiplicacion = n1 * n2;
            division = n1 / n2;

            Console.WriteLine("La suma de los dos números es: " + suma);
            Console.WriteLine("La resta de los dos números es: " + resta);
            Console.WriteLine("La multiplicación de los dos números es: " + multiplicacion);
            Console.WriteLine("La división de los dos números es: " + division);
        }
    }
}
