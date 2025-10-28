def edades():
    Almacen = 0
    promedio = 0
    orden = 0

    while True:
        orden += 1
        edad = int(input(f"\n{orden}-Ingrese la edad o 0 para finalizar: "))

        match edad:
            case n if n > 0:
                Almacen += edad
                promedio += 1
            case 0:
                if promedio > 0:
                    print(f"Promedio: {Almacen / promedio}")
                else:
                    print("No se ingresaron edades válidas.")
                print("Programa finalizado.")
                break
            case n if n < 0:
                print("Error: la edad no puede ser negativa. Ingrese otra edad.")

def numeros():
    
    numeros = int(input("Ingresa tu edad: "))
    for i in range (numeros):
        print (i+1)

def numerosR():   
    for i in range (10):
        print (i+1)

def dosNum():
    numero1= int(input("Ingrese el primer numero: "))
    numero2= int(input("Ingrese el segundo numero: "))
    
    inicio= min(numero1, numero2)
    fin = max(numero1, numero2)

    for i in range(inicio, fin + 1):
        if i % 2 == 0:
            print(i)

dosNum()
