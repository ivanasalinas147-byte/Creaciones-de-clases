#include <iostream>
using namespace std;

class Fecha
{
private:
    int mes;
    int dia;
    int anio;

public:
    Fecha(int mes, int dia, int anio)
    {
        this->mes = mes;
        this->dia = dia;
        this->anio = anio;
    }

    void mostrarFecha()
    {
        cout << mes << "/" << dia << "/" << anio << endl;
    }
};

int main()
{
    int mes;
    int dia;
    int anio;

    cout << "Ingrese el mes: ";
    cin >> mes;

    cout << "Ingrese el dia: ";
    cin >> dia;

    cout << "Ingrese el anio: ";
    cin >> anio;

    Fecha fecha(mes, dia, anio);

    cout << "\nFecha: ";
    fecha.mostrarFecha();

    return 0;
}