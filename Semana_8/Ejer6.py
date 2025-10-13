dolar = 3.78
euro = 4.20
while True:
    soles = float(input("Ingrese el monto en soles: "))

    def conv_dolar():
        return round (soles / dolar)

    def conv_euros():
        return round(soles / euro)

    print("\nBienvenido al sistema de conversion de modena")
    print("1. Dolares")
    print("2.Euros")

    opc = int(input("Ingrese una opcion: "))

    match opc:
        case 1:
            print(f"\nConversion a dolares: {conv_dolar()} ")
        case 2:
            print(f"\nConversion a Euros: {conv_euros()} ")

        case _:
            print("Opcion no valida.")

    continuar = input("¿Desea continuar? presiones(y)").upper()
    
    if continuar != "Y":
        print("Programa finalizado.")
        break
