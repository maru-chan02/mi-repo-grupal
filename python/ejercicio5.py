"""Ejercicio_5: clasificador de notas.

El programa solicita una nota final del 0 al 20, valida el rango y muestra
la clasificación correspondiente.
"""


def es_valida(nota):
    return 0 <= nota <= 20


def clasificar_nota(nota):
    if nota >= 18:
        return "Excelente"
    elif nota >= 14:
        return "Bueno"
    elif nota >= 11:
        return "Regular"
    else:
        return "Desaprobado"


def mostrar_reporte(nota, clasificacion):
    print("\n=== REPORTE ===")
    print(f"Nota ingresada: {nota}")
    print(f"Clasificación: {clasificacion}")


def main():
    try:
        nota = int(input("Ingrese la nota final: "))
    except ValueError:
        print("Error: ingrese un número entero válido entre 0 y 20.")
        return

    if es_valida(nota):
        clasificacion = clasificar_nota(nota)
        mostrar_reporte(nota, clasificacion)
    else:
        print("Error: la nota debe estar entre 0 y 20.")


if __name__ == "__main__":
    main()
