from Triangulo import Triangulo
from Cuadrado import Cuadrado
from Rectangulo import Rectangulo
from Trapecio import Trapecio
c = Cuadrado()
t = Triangulo()
r = Rectangulo ()
tr = Trapecio()

def menu1()->None:
    print("Bienvenidos a calculos de areas y perimetros\n")
    print("******* Menu de opciones *******")
    print("*     1. Triangulo    *")
    print("*     2. Cuadrado     *")
    print("*     3. Rectangulo   *")
    print("*     4. Trapecio     *")
    print("*     0. Salir        *")
    print("*******************************")


def menu2()->int:
    print("***** seleccione calculo ******")    
    print("*      1. Area         *")
    print("*      2. Perimetro    *")
    print("*****************************\n")

    opcion = int(input("Ingrese una opcion: "))
    return opcion

while True:
    while True:
        menu1()
        opcion = int(input("Ingrese opcion: "))

        if opcion in range(0,5): 
            break
        else: 
            print("Error. Opcion no valida. \n")
    match opcion:
        case 0: 
            quit() #exit()
        case 1:
            opc = menu2()

            match opc:
                case 1: 
                    t.area()
                case 2: 
                    t.perimetro()
        case 2:
            opc = menu2()
            l = int(input("Ingrese lado: "))

            match opc:
                case 1:
                    c.area(l);
                case 2:
                    c.perimetro(l)
            print()

        case 3:
            opc = menu2()
            match opc:
                case 1:
                    print(f"Area: {r.area()}")
                case 2:
                    print(f"Perimetro: {r.perimetro()}")
            print()

        case 4:

            opc = menu2()
            BaseMayor = int(input("\nIngrese base mayor: "))
            BaseMenor = int(input("Ingrese base menor: "))
            Altura = int(input("Ingrese la altura: "))
            match opc:
                case 1:
                    print(f"Area: {tr.area(BaseMayor, BaseMenor,Altura)}")
                case 2:
                    print(f"Perimetro: {tr.perimetro(BaseMayor, BaseMenor,Altura)}")

            print()

    while True:
        conti= input("\n¿Desea continuar? (s/n): ").lower()
        if conti in ("s", "n"):
            break
        else:
            print("Error. Solo 's' o 'n'. ")

    if conti == "n":
        break

