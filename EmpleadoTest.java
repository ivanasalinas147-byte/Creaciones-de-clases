import java.util.Scanner;

public class EmpleadoTest {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.println("Ingrese el primer nombre del empleado 1:");
        String nombre1 = input.nextLine();

        System.out.println("Ingrese el apellido paterno del empleado 1:");
        String apellido1 = input.nextLine();

        System.out.println("Ingrese el salario mensual del empleado 1:");
        double salario1 = input.nextDouble();

        input.nextLine();

        System.out.println("\nIngrese el primer nombre del empleado 2:");
        String nombre2 = input.nextLine();

        System.out.println("Ingrese el apellido paterno del empleado 2:");
        String apellido2 = input.nextLine();

        System.out.println("Ingrese el salario mensual del empleado 2:");
        double salario2 = input.nextDouble();

        Empleado empleado1 = new Empleado(
            nombre1, apellido1, salario1
        );

        Empleado empleado2 = new Empleado(
            nombre2, apellido2, salario2
        );

        System.out.println("\n--- SALARIO ANUAL ANTES DEL AUMENTO ---");

        System.out.println(nombre1 + " " + apellido1 +
                ": $" + empleado1.obtenerSalarioAnual());

        System.out.println(nombre2 + " " + apellido2 +
                ": $" + empleado2.obtenerSalarioAnual());

        empleado1.aumentarSalario();
        empleado2.aumentarSalario();

        System.out.println("\n--- SALARIO ANUAL DESPUES DEL AUMENTO DEL 10% ---");

        System.out.println(nombre1 + " " + apellido1 +
                ": $" + empleado1.obtenerSalarioAnual());

        System.out.println(nombre2 + " " + apellido2 +
                ": $" + empleado2.obtenerSalarioAnual());

        input.close();
    }
}