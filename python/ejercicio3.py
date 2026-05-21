def calcular_bruto(horas):
    return horas * 12.50

def calcular_descuento(bruto):
    return bruto * 0.05

def calcular_neto(bruto, descuento):
    return bruto - descuento

horas = float(input("Horas trabajadas: "))

bruto = calcular_bruto(horas)
descuento = calcular_descuento(bruto)
neto = calcular_neto(bruto, descuento)

print("\n=== BOLETA DE SUELDO ===")
print(f"Sueldo bruto: S/ {bruto:.2f}")
print(f"Descuento (5%): S/ {descuento:.2f}")
print(f"Sueldo neto: S/ {neto:.2f}")