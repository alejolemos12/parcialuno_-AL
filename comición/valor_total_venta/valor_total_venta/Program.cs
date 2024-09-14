﻿
public class Program
{
    private static void Main(string[] args)
    {
        // Solicitar el sueldo base
        Console.Write("Ingrese el sueldo base del vendedor: ");
        double sueldoBase = Convert.ToDouble(Console.ReadLine());

        // Solicitar los montos de las ventas
        Console.Write("Ingrese el monto de la primera venta: ");
        double venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto de la segunda venta: ");
        double venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto de la tercera venta: ");
        double venta3 = Convert.ToDouble(Console.ReadLine());

        // Calcular las comisiones (10% de cada venta)
        double comision1 = venta1 * 0.10;
        double comision2 = venta2 * 0.10;
        double comision3 = venta3 * 0.10;

        // Calcular el total de comisiones
        double totalComisiones = comision1 + comision2 + comision3;

        // Calcular el total que recibirá el vendedor
        double totalRecibido = sueldoBase + totalComisiones;

        // Mostrar el resultado
        Console.WriteLine("\nTotal de comisiones: $" + totalComisiones);
        Console.WriteLine("Total que recibirá el vendedor: $" + totalRecibido);
    }
}
