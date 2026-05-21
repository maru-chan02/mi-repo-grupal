def calcular_subtotal(cantidad, precio_unitario):
    return cantidad * precio_unitario

def calcular_igv(subtotal):
    return subtotal * 0.18

def calcular_total(subtotal, igv):
    return subtotal + igv

cantidad = int(input("Ingrese la cantidad comprada: "))
precio_unitario = float(input("Ingrese el precio unitario: S/"))

subtotal = calcular_subtotal(cantidad, precio_unitario)
igv = calcular_igv(subtotal)
total = calcular_total(subtotal, igv)

print("\n=== BOLETA DE VENTA ===")
print(f"Cantidad: {cantidad}")
print(f"Precio unitario: S/{precio_unitario:.2f}")
print(f"Subtotal: S/{subtotal:.2f}")
print(f"IGV (18%): S/{igv:.2f}")
print(f"Total a pagar: S/{total:.2f}")