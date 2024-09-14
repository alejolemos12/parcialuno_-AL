



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
        Console.WriteLine("\nTotal de comisiones: $" + totalComisiones.ToString("F2"));
        Console.WriteLine("Total que recibirá el vendedor: $" + totalRecibido.ToString("F2"));

        // Determinar cuál fue la venta que recibió mayor comisión
        double mayorComision = Math.Max(comision1, Math.Max(comision2, comision3));

        if (mayorComision == comision1)
        {
            Console.WriteLine($"La venta que recibió mayor comisión es la primera con un monto: ${venta1.ToString("F2")}");
        }
        else if (mayorComision == comision2)
        {
            Console.WriteLine($"La venta que recibió mayor comisión es la segunda con un monto: ${venta2.ToString("F2")}");
        }
        else
        {
            Console.WriteLine($"La venta que recibió mayor comisión es la tercera con un monto: ${venta3.ToString("F2")}");
        }

        // Calcular el porcentaje de comisión para cada venta
        double porcentajeComision1 = (comision1 / venta1) * 100;
        double porcentajeComision2 = (comision2 / venta2) * 100;
        double porcentajeComision3 = (comision3 / venta3) * 100;

        // Calcular el promedio de los porcentajes de comisión
        double promedioPorcentajeComisiones = (porcentajeComision1 + porcentajeComision2 + porcentajeComision3) / 3;

        // Mostrar el promedio de comisiones
        Console.WriteLine($"El promedio del porcentaje de comisiones es: {promedioPorcentajeComisiones.ToString("F2")}%");
    }
}


