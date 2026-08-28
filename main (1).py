class Factura:

    def __init__(self, numeroPieza, descripcionPieza,
                 cantidad, precioArticulo):

        self.numeroPieza = numeroPieza
        self.descripcionPieza = descripcionPieza

        if cantidad > 0:
            self.cantidad = cantidad
        else:
            self.cantidad = 0

        if precioArticulo > 0:
            self.precioArticulo = precioArticulo
        else:
            self.precioArticulo = 0.0

    def obtenerMontoFactura(self):
        return self.cantidad * self.precioArticulo

    def mostrarFactura(self):
        print("\n--- FACTURA ---")
        print("Numero de pieza:", self.numeroPieza)
        print("Descripcion:", self.descripcionPieza)
        print("Cantidad:", self.cantidad)
        print("Precio: $", self.precioArticulo)
        print("Monto de la factura: $",
              self.obtenerMontoFactura())


print("Ingrese el numero de pieza:")
numeroPieza = input()

print("Agregar la descripcion:")
descripcionPieza = input()

print("Cantidad:")
cantidad = int(input())

print("Precio:")
precioArticulo = float(input())

ferre = Factura(
    numeroPieza,
    descripcionPieza,
    cantidad,
    precioArticulo
)

ferre.mostrarFactura()