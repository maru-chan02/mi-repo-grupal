
peso = float(input("Ingrese el peso en kg: "))
estatura = float(input("Ingrese la estatura en metros: "))

imc = peso / (estatura ** 2)

# Redondear a 2 decimales
imc_red = round(imc, 2)

print(f"IMC: {imc_red}")

if imc < 18.5:
    print("Bajo peso - Azul")
elif imc < 25:
    print("Normal - Verde")
elif imc < 30:
    print("Sobrepeso - Amarillo")
else:
    print("Obesidad - Rojo")