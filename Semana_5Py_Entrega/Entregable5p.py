def ejer1():
    precio = float(input("Ingrese el precio del producto: "))
    error = False

    if precio <= 0:
        print("Error, el precio no puede ser menor o igual a 0.")
        error = True
    else:
        print("\nCodigo de descuento:")
        print("[1] Estudiante")
        print("[2] Empleado")
        print("[3] Cliente frecuente")
        codigo = int(input("Ingrese el codigo: "))
        
        match codigo:
            case 1:
                descuento = precio * 0.10
            case 2:
                descuento = precio * 0.15
            case 3:
                descuento = precio * 0.20
            case _:
                print("Error, codigo incorrecto.")
                error = True

        if not error and precio > 500:
            descuento = descuento + (precio - descuento) * 0.05

    if not error:
        print(f"Precio: ${precio:.2f}")
        print(f"Descuento: ${descuento:.2f}")
        print(f"Total: ${precio - descuento:.2f}")



import math
def ejer2():
    nota = int(input("Ingrese la nota: "))
    error = False

    if nota < 0 or nota > 20:
        print("Error, nota fuera del rango 0-20.")
        error = True
    elif nota >= 18 and nota <= 20:
        clasificacion = "Excelente"
    elif nota >= 14 and nota <= 17:
        clasificacion = "Bueno"
    elif nota >= 11 and nota <= 13:
        clasificacion = "Regular"
    elif nota >= 0 and nota <= 10:
        clasificacion = "Desaprobado"

    if not error:
        if nota >= 14 and nota % 2 == 0:
            desempeno = "Buen desempeno con nota par"
        else:
            desempeno = "Necesita reforzar"

        print(f"Raiz: {round(math.sqrt(nota), 1)}")
        print(f"Cubo: {math.pow(nota, 3)}")
        print(f"Clasificacion: {clasificacion}")
        print(f"Desempeno: {desempeno}")

ejer1()
