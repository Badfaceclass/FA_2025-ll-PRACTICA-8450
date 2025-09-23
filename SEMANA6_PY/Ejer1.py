num = int(input("\nIngrese un numero positivo: "))
while num <= 0:
    num = int(input("Error. Ingrese un numero positivo: "))

i = 1
while i <= 12:
    print(f"{i} x {num} = {i*num}")
    i+=1
