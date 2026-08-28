#include <iostream>
#include <string>
using namespace std;

class Factura
{
private:
    string numeroPieza;
    string descripcionPieza;
    int cantidad;
    double precioArticulo;

public:
    Factura(string numeroPieza, string descripcionPieza,
            int cantidad, double precioArticulo)
    {
        this->numeroPieza = numeroPieza;
        this->descripcionPieza = descripcionPieza;

        if (cantidad > 0)
        {
            this->cantidad = cantidad;
        }
        else
        {
            this->cantidad = 0;
        }

        if (precioArticulo > 0)
        {
            this->precioArticulo = precioArticulo;
        }
        else
        {
            this->precioArticulo = 0.0;
        }
    }

    double obtenerMontoFactura()
    {
        return cantidad * precioArticulo;
    }

    void mostrarFactura()
    {
        cout << "\n--- FACTURA ---" << endl;
        cout << "Numero de pieza: " << numeroPieza << endl;
        cout << "Descripcion: " << descripcionPieza << endl;
        cout << "Cantidad: " << cantidad << endl;
        cout << "Precio: $" << precioArticulo << endl;
        cout << "Monto de la factura: $"
             << obtenerMontoFactura() << endl;
    }
};

int main()
{
    string numeroPieza;
    string descripcionPieza;
    int cantidad;
    double precioArticulo;

    cout << "Ingrese el numero de pieza: ";
    getline(cin, numeroPieza);

    cout << "Agregar la descripcion: ";
    getline(cin, descripcionPieza);

    cout << "Cantidad: ";
    cin >> cantidad;

    cout << "Precio: ";
    cin >> precioArticulo;

    Factura ferre(
        numeroPieza,
        descripcionPieza,
        cantidad,
        precioArticulo
    );

    ferre.mostrarFactura();

    return 0;
}