filas = int(input("Ingrese numero de filas: "))
columnas = int(input("Ingrese numero de columnas: "))

i = 0
while i < filas:
    j=0
    while j < columnas:
        print("*", end = "")
        j+=1
    print("*")
    i += 1