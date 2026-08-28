import java.util.Scanner;

public class FechaTest {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.println("Ingrese el mes:");
        int mes = input.nextInt();

        System.out.println("Ingrese el dia:");
        int dia = input.nextInt();

        System.out.println("Ingrese el anio:");
        int anio = input.nextInt();

        Fecha fecha = new Fecha(mes, dia, anio);

        System.out.println("\nFecha:");
        fecha.mostrarFecha();

        input.close();
    }
}