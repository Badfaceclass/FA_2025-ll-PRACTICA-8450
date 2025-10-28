generar = input("Genere una contraseña: ")
print("--------------------------")
print("  Valida tu contraseña")
print(" Ud. Tiene 3 intentos")
print("--------------------------")

intentos = 0
while intentos > 0:
    contraseña = input("\nIngrese la contraseña: ")
    
    if generar == contraseña:
        print("\nAcceso concedido. Bienvenido al sistema.")
        break

    else:
        intentos -= 1
        print("Contraseña incorrecta")
        print(f"Intentos restantes: {intentos}")

else: print("Acceso denegado, ocerrando sistema.")