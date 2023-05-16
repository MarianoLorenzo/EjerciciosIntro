using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double montoSinDescuento, totalACobrar;

            Console.WriteLine("Ingrese el monto total de la compra");
            montoSinDescuento = double.Parse(Console.ReadLine());

            totalACobrar = montoSinDescuento * 0.85;

            Console.WriteLine("El total a cobrar es: $" + totalACobrar.ToString("0.00"));
        }
    }
}
