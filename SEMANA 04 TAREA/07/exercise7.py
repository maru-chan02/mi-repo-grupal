pc01=int(input("Ingresar nota de practica 01: "))
pc02=int(input("Ingresar nota de practica 02: "))
pc03=int(input("Ingresar nota de practica 03: "))
ep=int(input("Ingresar nota de examen parcial: "))
ef=int(input("Ingresar nota de examen final: "))

minimo=min(pc01,pc02,pc03)
prom_prac=(pc01+pc02+pc03-minimo)/2
prom_final=(ep+ef+prom_prac)/3

print(f"Promedio final de {prom_final}")
print(f"Promedio de prácticas {prom_prac}")

if prom_final>=18:
    print("Excelente")
elif prom_final>=14:
    print("Bueno")
elif prom_final>=10:
    print("Regular")
else:
    print("Deficiente")