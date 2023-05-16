using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmEntreCiudades, velocidad, tiempoEnLlegar;

            Console.WriteLine("Ingrese los kilómetros existentes entre dos ciudades");
            kmEntreCiudades = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio del vehículo");
            velocidad = double.Parse(Console.ReadLine());

            tiempoEnLlegar = kmEntreCiudades / velocidad;

            Console.WriteLine("Se tardará en llegar: " + tiempoEnLlegar.ToString("0.00") + " horas");
        }
    }
}
