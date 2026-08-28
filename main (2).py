class Empleado:

    def __init__(self, primerNombre, apellidoPaterno, salarioMensual):

        self.primerNombre = primerNombre
        self.apellidoPaterno = apellidoPaterno

        if salarioMensual > 0:
            self.salarioMensual = salarioMensual
        else:
            self.salarioMensual = 0.0

    def obtenerSalarioAnual(self):
        return self.salarioMensual * 12

    def aumentarSalario(self):
        self.salarioMensual = self.salarioMensual * 1.10

    def mostrarEmpleado(self):
        print("Empleado:", self.primerNombre, self.apellidoPaterno)
        print("Salario anual: $", self.obtenerSalarioAnual())


print("Ingrese el primer nombre del empleado 1:")
nombre1 = input()

print("Ingrese el apellido paterno del empleado 1:")
apellido1 = input()

print("Ingrese el salario mensual del empleado 1:")
salario1 = float(input())

print("\nIngrese el primer nombre del empleado 2:")
nombre2 = input()

print("Ingrese el apellido paterno del empleado 2:")
apellido2 = input()

print("Ingrese el salario mensual del empleado 2:")
salario2 = float(input())


empleado1 = Empleado(nombre1, apellido1, salario1)
empleado2 = Empleado(nombre2, apellido2, salario2)


print("\n--- SALARIO ANUAL ANTES DEL AUMENTO ---")

empleado1.mostrarEmpleado()
empleado2.mostrarEmpleado()


empleado1.aumentarSalario()
empleado2.aumentarSalario()


print("\n--- SALARIO ANUAL DESPUES DEL AUMENTO DEL 10% ---")

empleado1.mostrarEmpleado()
empleado2.mostrarEmpleado()