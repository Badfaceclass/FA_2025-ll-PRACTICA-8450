class Triangulo:
	def area(self)->None:
		b= int(input("\nIngrese la base: "))
		h= int(input("\nIngrese la altura: "))

		print(f"\tArea: {(b*h/2)}")

	def perimetro(self)->None:
		l1 = int(input("\nIngrese lado 1: "))
		l2 = int(input("\nIngrese lado 2: "))
		l3 = int(input("\nIngrese lado 3: "))

		print(f"Perimetro: {l1+l2+l3}")