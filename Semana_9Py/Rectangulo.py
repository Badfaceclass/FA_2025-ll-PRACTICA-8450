class Rectangulo:
    def area(self) -> float:
        b = int(input("\nIngrese la base: "))
        h = int(input("Ingrese la altura: "))
        return b * h   

    def perimetro(self) -> float:
        b = int(input("\nIngrese la base: "))
        h = int(input("Ingrese la altura: "))
        return 2 * (b + h)