ed=int(input("ingrese su edad: "))

if ed>=18:
    print("eres mayor de edad. adelante")
else:
    faltan=abs(18-ed)
    print("eres menor de edad")
    print(f"te falta {fe} años para ingresar")
