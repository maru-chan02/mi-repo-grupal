nota = int(input("Ingrese su promedio: "))

if nota < 0 or nota > 20:
    print("inválido")
elif nota >= 15 and nota <= 20:
    print("excelente")
elif nota >= 11 and nota <= 14:
    print("bueno")
elif nota >= 6 and nota <= 10:
    print("regular")
else:  # de 0 a 5
    print("deficiente")

print(f"Nota: {nota}")