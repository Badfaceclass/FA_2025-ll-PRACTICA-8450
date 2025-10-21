class Cajero:
    saldo = 1000

    def Menu(self) -> int:
        opc = -1
        while opc != 0:
            print("\nBienvenido al cajero.")
            print("[1] Consultar Saldo")
            print("[2] Depositar")
            print("[3] Retirar")
            print("[0] Salir")

            opc = int(input("Ingrese la opcion: "))

            match opc:
                case 1:
                    print(f"Su saldo es: {self.Consultar()}")
                case 2:
                    monto = float(input("Ingrese el monto a depositar: "))
                    self.Depositar(monto)
                case 3:
                    monto = float(input("Ingrese el monto a retirar: "))
                    self.Retirar(monto)
                case 0:
                    print("Gracias por usar el cajero.")
                case _:
                    print("Opcion invalida.")

        return opc

    def Consultar(self) -> float:
        return Cajero.saldo
    
    def Depositar(self, monto: float) -> None:
        while(True):
            if monto < 0:
                print("\nNo se puede depositar 0 o un valor negativo.")
                monto = float(input("Ingrese nuevamente el monto a depositar: "))

            elif monto == 0:
                print("Deposito cancelado.")
                break
            else:
                Cajero.saldo += monto
                print(f"Deposito exitoso. Saldo actual: {Cajero.saldo}")
                break

    def Retirar(self, monto: float) -> None:
        while(True):
            if monto < 0:
                print("\nNo se puede retirar 0 o un valor negativo.")
                monto = float(input("Ingrese nuevamente el monto a retirar:"))

            elif monto == 0:
                print("Retiro cancelado.")
                break

            elif monto > Cajero.saldo:
                print("Saldo insuficiente.")
                monto = float(input("Ingrese nuevamente el monto a retirar: "))

            else:
                Cajero.saldo -= monto
                print(f"Retiro exitoso. Saldo actual: {Cajero.saldo}")
                break
