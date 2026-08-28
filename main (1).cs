using System;

public class Empleado
{
    private string primerNombre;
    private string apellidoPaterno;
    private double salarioMensual;

    public Empleado(string primerNombre, string apellidoPaterno,
                    double salarioMensual)
    {
        this.primerNombre = primerNombre;
        this.apellidoPaterno = apellidoPaterno;

        if (salarioMensual > 0)
        {
            this.salarioMensual = salarioMensual;
        }
        else
        {
            this.salarioMensual = 0.0;
        }
    }

    public double ObtenerSalarioAnual()
    {
        return salarioMensual * 12;
    }

    public void AumentarSalario()
    {
        salarioMensual = salarioMensual * 1.10;
    }

    public void MostrarEmpleado()
    {
        Console.WriteLine("Empleado: " + primerNombre + " " + apellidoPaterno);
        Console.WriteLine("Salario anual: $" + ObtenerSalarioAnual());
    }
}

public class EmpleadoTest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer nombre del empleado 1:");
        string nombre1 = Console.ReadLine();

        Console.WriteLine("Ingrese el apellido paterno del empleado 1:");
        string apellido1 = Console.ReadLine();

        Console.WriteLine("Ingrese el salario mensual del empleado 1:");
        double salario1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese el primer nombre del empleado 2:");
        string nombre2 = Console.ReadLine();

        Console.WriteLine("Ingrese el apellido paterno del empleado 2:");
        string apellido2 = Console.ReadLine();

        Console.WriteLine("Ingrese el salario mensual del empleado 2:");
        double salario2 = Convert.ToDouble(Console.ReadLine());

        Empleado empleado1 = new Empleado(
            nombre1, apellido1, salario1
        );

        Empleado empleado2 = new Empleado(
            nombre2, apellido2, salario2
        );

        Console.WriteLine("\n--- SALARIO ANUAL ANTES DEL AUMENTO ---");

        empleado1.MostrarEmpleado();
        empleado2.MostrarEmpleado();

        empleado1.AumentarSalario();
        empleado2.AumentarSalario();

        Console.WriteLine("\n--- SALARIO ANUAL DESPUES DEL AUMENTO DEL 10% ---");

        empleado1.MostrarEmpleado();
        empleado2.MostrarEmpleado();
    }
}