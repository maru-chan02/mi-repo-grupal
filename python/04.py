import random

secreto = random.randint(1, 50)  
intentos = 0
max_intentos = 7
adivino = False

print("Adivina el número entre 1 y 50. Tienes 7 intentos.")


while intentos < max_intentos and adivino == False:
    intentos = intentos + 1

    intento = int(input(f"Intento {intentos}: "))

    if intento == secreto:
        adivino = True           

    elif intento < secreto:      
        print("El número secreto es MAYOR.")

    else:
        print("El número secreto es MENOR.")


if adivino:
    print(f"Ganaste en {intentos} intentos.")
else:
    print(f"Perdiste. El número era {secreto}.")