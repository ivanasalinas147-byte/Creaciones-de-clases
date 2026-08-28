public class Factura {
    private String numeroPieza;
    private String descripcionPieza;
    private int cantidad;
    private double precioArticulo;

    public Factura(String numeroPieza, String descripcionPieza,
                   int cantidad, double precioArticulo) {

        this.numeroPieza = numeroPieza;
        this.descripcionPieza = descripcionPieza;

        if (cantidad > 0) {
            this.cantidad = cantidad;
        } else {
            this.cantidad = 0;
        }

        if (precioArticulo > 0) {
            this.precioArticulo = precioArticulo;
        } else {
            this.precioArticulo = 0.0;
        }
    }

    public double obtenerMontoFactura() {
        return cantidad * precioArticulo;
    }
}