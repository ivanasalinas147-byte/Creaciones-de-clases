public class Empleado {

    private String primerNombre;
    private String apellidoPaterno;
    private double salarioMensual;

    public Empleado(String primerNombre, String apellidoPaterno,
                    double salarioMensual) {

        this.primerNombre = primerNombre;
        this.apellidoPaterno = apellidoPaterno;

        if (salarioMensual > 0) {
            this.salarioMensual = salarioMensual;
        } else {
            this.salarioMensual = 0.0;
        }
    }

    public double obtenerSalarioAnual() {
        return salarioMensual * 12;
    }

    public void aumentarSalario() {
        salarioMensual = salarioMensual * 1.10;
    }
}