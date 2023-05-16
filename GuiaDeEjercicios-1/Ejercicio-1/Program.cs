using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese dos números");
            n1 = int.Parse(Console.ReadLine());
            n2=  int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
    }
}
