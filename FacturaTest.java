import java.util.Scanner;

public class FacturaTest {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.println("Ingrese el numero de pieza: ");
        String numeroPieza = input.nextLine();

        System.out.println("Agregar la descripcion: ");
        String descripcionPieza = input.nextLine();

        System.out.println("Cantidad: ");
        int cantidad = input.nextInt();

        System.out.println("Precio: ");
        double precioArticulo = input.nextDouble();

        Factura ferre = new Factura(
            numeroPieza,
            descripcionPieza,
            cantidad,
            precioArticulo
        );

        System.out.println("Factura: $" + ferre.obtenerMontoFactura());

        input.close();
    }
}