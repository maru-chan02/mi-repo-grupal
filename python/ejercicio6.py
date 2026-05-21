def calcular_consumo(m3):
    return m3 * 6.90


def calcular_costo(consumo):
    igv = consumo * 0.18
    total = consumo + igv
    return total


def mostrar_recibo(m3, consumo, total):
    print("\n=== RECIBO DE AGUA ===")
    print(f"Consumo en m3: {m3}")
    print(f"Consumo mensual: S/ {consumo:.2f}")
    print(f"Costo total con IGV: S/ {total:.2f}")


def main():
    try:
        m3 = int(input("Ingrese el consumo en m3: "))
    except ValueError:
        print("Error: ingrese un número entero válido.")
        return

    if m3 >= 0:
        consumo = calcular_consumo(m3)
        total = calcular_costo(consumo)
        mostrar_recibo(m3, consumo, total)
    else:
        print("Error: el consumo no puede ser negativo.")


if __name__ == "__main__":
    main()
