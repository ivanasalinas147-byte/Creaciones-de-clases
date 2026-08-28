public class Fecha {

    private int mes;
    private int dia;
    private int anio;

    public Fecha(int mes, int dia, int anio) {
        this.mes = mes;
        this.dia = dia;
        this.anio = anio;
    }

    public void mostrarFecha() {
        System.out.println(mes + "/" + dia + "/" + anio);
    }
}