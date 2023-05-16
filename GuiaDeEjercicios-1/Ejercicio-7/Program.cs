using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double metrosTotales, metrosCubiertos, porcentajeMetrosCubiertos, porcentajeMetrosDescubiertos;

            Console.WriteLine("Ingrese los metros cuadrados totales del predio");
            metrosTotales = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los metros cuadrados cubiertos del predio");
            metrosCubiertos = double.Parse(Console.ReadLine());

            porcentajeMetrosCubiertos = metrosCubiertos / metrosTotales * 100;
            porcentajeMetrosDescubiertos = (metrosTotales - metrosCubiertos) / metrosTotales * 100;

            Console.WriteLine("El porcentaje de metros cuadrados cubiertos es : " + porcentajeMetrosCubiertos.ToString("0.00") + " %");
            Console.WriteLine("El porcentaje de metros cuadrados descubiertos es : " + porcentajeMetrosDescubiertos.ToString("0.00") + " %");
        }
    }
}
