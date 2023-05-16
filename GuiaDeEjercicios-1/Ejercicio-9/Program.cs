using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidadMujeres, cantidadHombres, totalHombresMujeres, porcentajeMujeres, porcentajeHombres;          

            Console.WriteLine("Ingrese la cantidad de mujeres");
            cantidadMujeres = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de hombres");
            cantidadHombres = int.Parse(Console.ReadLine());

            totalHombresMujeres = cantidadHombres + cantidadMujeres;
            porcentajeMujeres = cantidadMujeres / totalHombresMujeres * 100;
            porcentajeHombres = cantidadHombres / totalHombresMujeres * 100;

            Console.WriteLine("El porcentaje de mujeres es: " + porcentajeMujeres.ToString("0.00") + "%");
            Console.WriteLine("El porcentaje de hombres es: " + porcentajeHombres.ToString("0.00") + "%");
        }
    }
}
