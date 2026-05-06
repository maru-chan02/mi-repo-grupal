saldo = 1000.00
retiros = 0

print("=== CAJERO AUTOMÁTICO ===")
print(f"Saldo disponible: S/{saldo:.2f}")

monto = float(input("Monto a retirar (0 para salir): "))

while monto != 0:           
    if monto < 0:           
        print("Error: monto inválido.")
    elif monto > saldo:    
        print("Error: saldo insuficiente.")
    else:
        saldo   = saldo   - monto    
        retiros = retiros + 1       

        print(f"Retiro exitoso. Saldo: S/{saldo:.2f}")

    monto = float(input("Monto a retirar (0 para salir): "))

print("--- RESUMEN ---")
print(f"Retiros realizados: {retiros}")
print(f"Saldo final: S/{saldo:.2f}")