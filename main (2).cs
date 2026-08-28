using System;

public class Fecha
{
    private int mes;
    private int dia;
    private int anio;

    public Fecha(int mes, int dia, int anio)
    {
        this.mes = mes;
        this.dia = dia;
        this.anio = anio;
    }

    public void MostrarFecha()
    {
        Console.WriteLine(mes + "/" + dia + "/" + anio);
    }
}

public class FechaTest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el mes:");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el dia:");
        int dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el anio:");
        int anio = Convert.ToInt32(Console.ReadLine());

        Fecha fecha = new Fecha(mes, dia, anio);

        Console.WriteLine("\nFecha:");
        fecha.MostrarFecha();
    }
}