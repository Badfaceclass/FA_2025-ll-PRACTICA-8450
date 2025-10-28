from mimetypes import suffix_map
from tkinter import SE


def ejer1():
    edad = int(input("Ingrese la edad: "))
    if edad >= 18:
        print("Puede votar.")
        if edad >= 25:
            print("Candidato para un cargo politico.")
        else:
            print("No es candidatos para un cargo politico.")
    else:
        print("No puede votar.")
        print("No puede ejercer un cargo politico.")


def ejer2():
    lado1 = int(input("Ingrese lado1"))
    lado2 = int(input("Ingrese lado2"))
    lado3 = int(input("Ingrese lado3"))

    if(lado1 == lado2 == lado3):
        print("EQUILATERO")
    else:
        if(lado1 == lado2 or lado1 == lado3):
            print("ISOSCELES")
        else:
            print("ESCALENO")

def ejer3():
    n = int(input("Ingrese un numero: "))
    suma = 0

    for i in range (1,n + 1):
        print(i)

        if i%2 == 0:
            suma+=i

    print(f"\nSuma de pares:{suma}")

def ejer4():
    cant= int(input("\nIngrese la cantidad de numeros: "))
    ceros = pares = impares = 0
    for i in range(1, cant +1):
        num = int(input(f"Ingrese el numero {i}: "))

        if num == 0:
            ceros+=1
        elif num %2 == 0:
             pares+=1
        else:
            impares +=1
    print(f"# Ceros: {ceros}")
    print(f"# Pares: {pares}")
    print(f"# Impares: {impares}")

ejer4()
