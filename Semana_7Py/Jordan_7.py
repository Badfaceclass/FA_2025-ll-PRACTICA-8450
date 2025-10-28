def ejer7_1():
    p = i = 0
    while True:
        num = int(input("Ingrese numero entero (Negativo par asalir): "))

        if num < 0:  break
        if num % 2 == 0: p+=1
        else: i+=1

    print(f"\nCantidad de pares: {p}")
    print(f"\nCantidad de impares: {i} ")


from ast import Num
import random
def ejer7_2():
    print("--------------------------------")
    print("Bienvenido al juego de adivinar")
    print(" 1. Adivinar el numero entre 1-20")
    print(" 2. Tienes 3 intentos")
    print("--------------------------------")

    intentos = 3
    secreto = random.randint(1,20)

    while intentos > 0:
        num = int(input("\nIngrese numero: "))

        if secreto == num:
            print("\nCorrecto! Adivinaste el numero.")
            break
        else:
            intentos -= 1 
            if num < secreto: 
                print(f"\nPista: El numero es mayor. Te quedan {intentos} intentos.")
            else: 
                print(f"\nPista: El numero es menor. Te quedan {intentos} intentos.")
    else:
        print(f"No lograste adivinar el numero: {secreto}.")


def ejer7_3():
    while True:
        suma = 0
        num = int(input("Ingrese un numero positivo: "))

        for i in range(1, num+1):
            suma += i  
            print(i, end = " ")

        print(f"\nSuma: {suma}")

        opc = input("¿Desea continuar? (S/N): ").upper()
        if opc == "N":
            break
        
ejer7_3()