def suma(a,b):
    print(f"\nLa suma es {a+b}")

def resta(a,b):
    print(f"\nLa resta es {a-b}")

def multiplicacion(a,b):
    print(f"\nLa multiplicacion es {a*b}")

def Division(a,b):
    if b!= 0:
        print(f"\nLa divicion es {a/b}")
    else:
        print("\nError. No se puede dividir entre 0.")

def operaciones():
     while True:
         print("Menu de operaciones")
         print("\n1. Suma")
         print("2. Resta")
         print("3. Multiplicacion")
         print("4. Division")

         opc = int(input("\nIngrese una opcion: "))

         a = int(input("Ingrese el primer numero: "))
         b = int(input("Ingrese el segundo numero: "))

         match opc:
            case 1:
                suma(a,b)
            case 2:
                resta(a,b)
            case 3:
                multiplicacion(a,b)
            case 4:
                Division(a,b)
            case _:
                print("Opcion no valida!")

         conti= input("¿Desea continuar? presione (y): ").upper()
         if conti != "Y":
             print("\nPrograma finalizado")
             break
 
operaciones()