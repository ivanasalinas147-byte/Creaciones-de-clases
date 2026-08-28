class Fecha:

    def __init__(self, mes, dia, anio):
        self.mes = mes
        self.dia = dia
        self.anio = anio

    def mostrarFecha(self):
        print(self.mes, "/", self.dia, "/", self.anio, sep="")


print("Ingrese el mes:")
mes = int(input())

print("Ingrese el dia:")
dia = int(input())

print("Ingrese el anio:")
anio = int(input())

fecha = Fecha(mes, dia, anio)

print("\nFecha:")
fecha.mostrarFecha()