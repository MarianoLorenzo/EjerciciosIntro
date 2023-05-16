using System;

namespace Ejercicio_5
{
    class Program
    {     
        static void Main(string[] args)
        {
            double sueldoFijo = 15000, facturadoPorEmpleado, sueldoTotal;    

            Console.WriteLine("Ingrese el total facturado por el empleado");
            facturadoPorEmpleado = double.Parse(Console.ReadLine());

            sueldoTotal = sueldoFijo + (facturadoPorEmpleado * 0.05);

            Console.WriteLine("El sueldo a cobrar es : $" + sueldoTotal.ToString("0,000.00"));
        }
    }
}
