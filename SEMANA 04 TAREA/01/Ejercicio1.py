monto = float(input("Ingrese el monto de la compra: "))
descuento = 0
if monto >= 100:
    descuento = monto * 0.10
total = monto - descuento
print(f"Descuento aplicado: S/ {round(descuento, 2)}")
print(f"Total a pagar: S/ {round(total, 2)}")