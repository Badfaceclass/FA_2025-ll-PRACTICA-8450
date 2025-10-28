using System;

namespace Entregable5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejer2();
            Console.ReadKey();
        }

        static void Ejer1()
        {
            double Precio, Descuento = 0;
            int Codigo;
            bool Error = false;

            Console.Write("Ingrese el precio del producto: ");
            Precio = Convert.ToDouble(Console.ReadLine());

            if (Precio <= 0)
            {
                Console.WriteLine("Error, el precio no puede ser menor o igual a 0.");
                Error = true;
            }
            else
            {
                Console.WriteLine("\nCodigo de descuento:");
                Console.WriteLine("[1] Estudiante");
                Console.WriteLine("[2] Empleado");
                Console.WriteLine("[3] Cliente frecuente");
                Codigo = Convert.ToInt32(Console.ReadLine());

                switch (Codigo)
                {
                    case 1:
                        Descuento = Precio * 0.10;
                        break;
                    case 2:
                        Descuento = Precio * 0.15;
                        break;
                    case 3:
                        Descuento = Precio * 0.20;
                        break;
                    default:
                        Console.WriteLine("Error, codigo incorrecto.");
                        Error = true;
                        break;
                }

                if (!Error && Precio > 500)
                {
                    Descuento = Descuento + (Precio - Descuento) * 0.05;
                }
            }

            if (!Error == false)
            {
                Console.WriteLine($"Precio: ${Precio}");
                Console.WriteLine($"Descuento: ${Math.Round(Descuento, 2)}");
                Console.WriteLine($"Total: {Math.Round(Precio - Descuento, 2)}");
            }
        }

        static void Ejer2()
        {
            int nota;
            bool Error = false;
            string clasificacion = "", desempeno;

            Console.Write("Ingrese la nota: ");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Error, nota fuera del rango 0-20.");
                Error = true;
            }
            else if (nota <= 20 && nota >= 18)
            {
                clasificacion = "Excelente";
            }
            else if (nota >= 14 && nota <= 17)
            {
                clasificacion = "Bueno";
            }
            else if (nota >= 11 && nota <= 13)
            {
                clasificacion = "Regular";
            }
            else if (nota >= 0 && nota <= 10)
            {
                clasificacion = "Desaprobado";
            }

            if (!Error)
            {
                if (nota >= 14 && nota % 2 == 0)
                {
                    desempeno = "Buen desempeno con nota par";
                }
                else
                {
                    desempeno = "Necesita reforzar";
                }

                Console.WriteLine($"Raiz: {Math.Round((Math.Sqrt(nota)), 1)}");
                Console.WriteLine($"Cubo: {(Math.Pow(nota, 3))}");
                Console.WriteLine($"Clasificacion: {clasificacion}");
                Console.WriteLine($"Desempeno: {desempeno}");
            }
        }
    }
}
