
saldo = float(input("Depósito inicial: S/"))
meta  = float(input("Meta a alcanzar: S/"))


tasa  = 0.015
meses = 0

print(f"Mes 0: S/{saldo:.2f}")


while saldo < meta:
    saldo = saldo * (1 + tasa)   
    meses = meses + 1             

    print(f"Mes {meses}: S/{saldo:.2f}")

print(f"\nAlcanzará la meta en {meses} meses.")