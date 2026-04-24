print("=== Menu de operaciones ===")
print("1. Calcular area de un circulo")
print("2. Calcular area de un cuadrado")
print("3. Calcular area de un triangulo")
print("4. Salir")

opcion = int(input("Seleccione una opcion: "))
match opcion:
    case 1:
        print("Elegiste circulo")
        print("Area del circulo = pi * r^2")
    case 2:
        print("Elegiste cuadrado")
        print("Area del cuadrado = lado^2")
    case 3:
        print("Elegiste triangulo")
        print("Area del triangulo = (base * altura) / 2")
    case 4:
        print("Saliendo del program...")
    case _:
        print("Opcion invalida. Ingresa un numero del 1 al 4")