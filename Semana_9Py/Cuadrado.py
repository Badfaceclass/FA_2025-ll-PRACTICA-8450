class Cuadrado:
    @staticmethod
    def area(l)->None:
        print(f"\nArea: {l*l}")

    @staticmethod #o usar self
    def perimetro(l)->None:
        print(4*l)