import math


def ejer1():
    nombre = input("Ingrese su nombreP: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido a FA de {carrera}")

def ejer2():
    print("\"Bueno\"")


def ejer3():
        x = int(input("Ingres el valor de x: "))
        y= int(input("Ingres el valor de y: "))

        print("Suma: ", (x + y))
        print("Resta: ", (x - y))
        print("Multiplicacion: ", (x * y))
        print("Division: ", (x / y))


import math
def ejer4():
    num = float(input("Ingrese un numero decimal:"))

    print("Raiz 2: ", math.sqrt(num))
    print("Redondeado: ", round(num,0))
    print("Al cubo: ", math.pow(num,3))
    print("Raiz 3: ", num**(1/3))

 

ejer4()