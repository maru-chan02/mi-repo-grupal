suma = 0
contador = 0
mayor = 0


menor = float("inf")

nota = float(input("Ingrese nota (-1 para terminar): "))


while nota != -1:
   
    if nota < 0 or nota > 20:       
        print("Nota inválida. Debe estar entre 0 y 20.")
    else:
        
        suma     = suma     + nota  
        contador = contador + 1      

        
        if nota > mayor:
            mayor = nota            

        
        if nota < menor:
            menor = nota             

    
    nota = float(input("Ingrese nota (-1 para terminar): "))


if contador > 0:
    promedio = suma / contador       

    print(f"Notas ingresadas: {contador}")
    print(f"Nota más alta: {mayor}")
    print(f"Nota más baja: {menor}")
    print(f"Promedio: {promedio:.2f}")
else:
    print("No se ingresaron notas válidas.")