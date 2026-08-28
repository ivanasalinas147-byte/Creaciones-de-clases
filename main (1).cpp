#include <iostream>
#include <string>
using namespace std;

class Empleado
{
private:
    string primerNombre;
    string apellidoPaterno;
    double salarioMensual;

public:
    Empleado(string primerNombre, string apellidoPaterno,
             double salarioMensual)
    {
        this->primerNombre = primerNombre;
        this->apellidoPaterno = apellidoPaterno;

        if (salarioMensual > 0)
        {
            this->salarioMensual = salarioMensual;
        }
        else
        {
            this->salarioMensual = 0.0;
        }
    }

    double obtenerSalarioAnual()
    {
        return salarioMensual * 12;
    }

    void aumentarSalario()
    {
        salarioMensual = salarioMensual * 1.10;
    }

    void mostrarEmpleado()
    {
        cout << "Empleado: " << primerNombre << " "
             << apellidoPaterno << endl;

        cout << "Salario anual: $"
             << obtenerSalarioAnual() << endl;
    }
};

int main()
{
    string nombre1;
    string apellido1;
    double salario1;

    string nombre2;
    string apellido2;
    double salario2;

    cout << "Ingrese el primer nombre del empleado 1: ";
    cin >> nombre1;

    cout << "Ingrese el apellido paterno del empleado 1: ";
    cin >> apellido1;

    cout << "Ingrese el salario mensual del empleado 1: ";
    cin >> salario1;

    cout << "\nIngrese el primer nombre del empleado 2: ";
    cin >> nombre2;

    cout << "Ingrese el apellido paterno del empleado 2: ";
    cin >> apellido2;

    cout << "Ingrese el salario mensual del empleado 2: ";
    cin >> salario2;

    Empleado empleado1(nombre1, apellido1, salario1);
    Empleado empleado2(nombre2, apellido2, salario2);

    cout << "\n--- SALARIO ANUAL ANTES DEL AUMENTO ---"
         << endl;

    empleado1.mostrarEmpleado();
    empleado2.mostrarEmpleado();

    empleado1.aumentarSalario();
    empleado2.aumentarSalario();

    cout << "\n--- SALARIO ANUAL DESPUES DEL AUMENTO DEL 10% ---"
         << endl;

    empleado1.mostrarEmpleado();
    empleado2.mostrarEmpleado();

    return 0;
}