stock = 500
total_vendido = 0

venta = int(input("Unidades vendidas (0 para salir): "))


while venta != 0:
    
    if venta < 0:
        print("Error: cantidad no puede ser negativa.")
    
    elif venta > stock:
        print(f"Error: stock insuficiente. Quedan {stock}")
    else:
        
        stock = stock - venta

        
        total_vendido = total_vendido + venta

        print(f"Venta registrada. Stock: {stock}")

    
    venta = int(input("Unidades vendidas (0 para salir): "))

print(f"Stock restante: {stock}")
print(f"Total vendido: {total_vendido}")