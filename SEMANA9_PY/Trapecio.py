class Trapecio:
    def area (self,BaseMayor, BaseMenor, Altura) -> int:
        Area = ((BaseMenor + BaseMayor)/2)* Altura
        return Area
    def perimetro(self,BaseMayor, BaseMenor, Altura) -> int:
        Perimetro = (BaseMenor + BaseMayor + Altura) / 2
        return Perimetro
