while True:
    nota = int(input("Ingrese nota (0-20): "))
    if 0 <= nota <= 20:
        break
    else:
        print("Error: nota debe ser entre 0 y 20.")

if nota >= 18:
    print("Clasificación: EXCELENTE")
elif nota >= 14:
    print("Clasificación: BUENO")
elif nota >= 11:
    print("Clasificación: REGULAR")
else:
    print("Clasificación: DESAPROBADO")