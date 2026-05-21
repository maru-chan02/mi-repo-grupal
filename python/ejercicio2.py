nota_aprobatoria = 11

def calcular_promedio(n1, n2, n3):
    return (n1 + n2 + n3) / 3

def clasificar_estudiante(promedio):
    if promedio >= nota_aprobatoria:
        return "Aprobado"
    else:
        return "Desaprobado"

def mostrar_reporte(promedio, estado):
    print("\n=== REPORTE DE NOTAS ===")
    print(f"Promedio: {promedio:.2f}")
    print(f"Estado: {estado}")

nota1 = float(input("Ingrese la nota 1: "))
nota2 = float(input("Ingrese la nota 2: "))
nota3 = float(input("Ingrese la nota 3: "))

promedio = calcular_promedio(nota1, nota2, nota3)
estado = clasificar_estudiante(promedio)

mostrar_reporte(promedio, estado)