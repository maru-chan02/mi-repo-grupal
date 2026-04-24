cat = input().upper()
horas = float(input())
anios = int(input())

tarifa = 0

if cat == "A":
    tarifa = 33.50
elif cat == "B":
    tarifa = 29.80
elif cat == "C":
    tarifa = 25.70
else:
    print("Categoría inválida")
    exit()

bono = 0

if anios <= 3:
    bono = 0.00
elif 4 <= anios <= 10:
    bono = 0.10
elif 11 <= anios <= 17:
    bono = 0.20
else:
    bono = 0.30

sueldo_final = tarifa * horas * (1 + bono)
print(f"Sueldo: S/. {sueldo_final:.2f}")