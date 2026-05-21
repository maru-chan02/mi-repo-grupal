# Constantes para el tipo de cambio y la comisión
TIPO_CAMBIO = 3.75
PORCENTAJE_COMISION = 0.02

def calcular_comision(soles):
    """Calcula el 2% de comisión sobre el monto en soles."""
    return soles * PORCENTAJE_COMISION

def calcular_monto_neto(soles, comision):
    """Resta la comisión al monto original en soles."""
    return soles - comision

def convertir_a_dolares(monto_neto_soles):
    """Divide el monto neto entre el tipo de cambio."""
    return monto_neto_soles / TIPO_CAMBIO

def mostrar_comprobante(inicial, comision, neto, dolares):
    print("\n=======================================")
    print("          COMPROBANTE DE PAGO          ")
    print("=======================================")
    print(f"Monto original en Soles : S/ {inicial:.2f}")
    print(f"Comisión cobrada (2%)   : S/ {comision:.2f}")
    print(f"Monto neto en Soles     : S/ {neto:.2f}")
    print("---------------------------------------")
    print(f"Tipo de cambio aplicado : S/ {TIPO_CAMBIO:.2f} por $1")
    print(f"TOTAL A RECIBIR         : $ {dolares:.2f}")
    print("=======================================\n")

soles_ingresados = float(input("Ingrese el monto en soles (S/): "))
comision = calcular_comision(soles_ingresados)
monto_neto = calcular_monto_neto(soles_ingresados, comision)
dolares_recibidos = convertir_a_dolares(monto_neto)

mostrar_comprobante(soles_ingresados, comision, monto_neto, dolares_recibidos)