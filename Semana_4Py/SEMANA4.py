def ejer1():
    edad = int(input("Ingres la edad"))

    if edad < 18:
        print("Menor de edad")
    if edad >= 18 and edad <= 64:
        print("Adulto")
    if edad >= 65:
        print("Adulto mayor")


def ejer2():
    annio = int(input("Ingrese eñ año: "))

    if (annio % 4 == 0 and annio % 100 != 0) or (annio % 400 == 0):
        print("n\El año es bisiesto")
    else:
        print("n\El año no es bisiesto")
    if annio % 2 == 0:
        print ("El año es par")
    else:
        print("El año es impar")

def ejer3():
    monto = float(input("Ingrese el monto en soles: "))

    print("\n1. Dolares\n2. Euros")

    opcion = int (input("\nIngrese una opcion: "))

    match opcion:
        case 1: print("Dolares: ", (monto/3.75,0))
        case 2: print(f"Euros: {monto/4.05:.2f}")
        case _: print("Opcion incorrecta.")

import math
def ejer4():
     print("Bienvenido al sistema de calculos de areas\n")
     print("1. Cuadrado")
     print("2. Rectangulo")
     print("3. Triangulo")
     print("4. Circulo\n")
     opcion = int(input("Ingrese una opcion: "))
     match opcion:
         case 1:
             lado = int(input("Ingrese lado: "))
             print("Area del cuadrado:", lado**2)
         case 2:
             bse = int(input("Ingrese la base: "))
             alt = int(input("Ingrese la altura: "))
             print("Area del rectangulo: ", (bse*alt))
         case 3:
             bse = int(input("Ingrese la base: "))
             alt = int(input("Ingrese la altura: "))
             print("Area del Triangulo: ", ((bse*alt)/2))

         case 4:
             radio = float(input("Ingrese el radio: "))
             print("Area del circulo: ", (round(math.pi*radio**2),2))
         case _: print("Opcion incorrecta")





ejer4()

