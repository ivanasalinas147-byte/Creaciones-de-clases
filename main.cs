using System;

public class Factura
{
    private string numeroPieza;
    private string descripcionPieza;
    private int cantidad;
    private double precioArticulo;

    public Factura(string numeroPieza, string descripcionPieza,
                   int cantidad, double precioArticulo)
    {
        this.numeroPieza = numeroPieza;
        this.descripcionPieza = descripcionPieza;

        if (cantidad > 0)
        {
            this.cantidad = cantidad;
        }
        else
        {
            this.cantidad = 0;
        }

        if (precioArticulo > 0)
        {
            this.precioArticulo = precioArticulo;
        }
        else
        {
            this.precioArticulo = 0.0;
        }
    }

    public double ObtenerMontoFactura()
    {
        return cantidad * precioArticulo;
    }

    public void MostrarFactura()
    {
        Console.WriteLine("\n--- FACTURA ---");
        Console.WriteLine("Numero de pieza: " + numeroPieza);
        Console.WriteLine("Descripcion: " + descripcionPieza);
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Precio: $" + precioArticulo);
        Console.WriteLine("Monto de la factura: $" + ObtenerMontoFactura());
    }
}

public class FacturaTest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el numero de pieza:");
        string numeroPieza = Console.ReadLine();

        Console.WriteLine("Agregar la descripcion:");
        string descripcionPieza = Console.ReadLine();

        Console.WriteLine("Cantidad:");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Precio:");
        double precioArticulo = Convert.ToDouble(Console.ReadLine());

        Factura ferre = new Factura(
            numeroPieza,
            descripcionPieza,
            cantidad,
            precioArticulo
        );

        ferre.MostrarFactura();
    }
}