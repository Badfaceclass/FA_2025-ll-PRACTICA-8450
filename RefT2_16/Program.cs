using System;
using Biblioteca1;

namespace RefT2_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double TotalPagar;

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Class1.Binvenida(Nombre);

            TotalPagar = Class1.MontoPagar();

            Console.WriteLine("Por lo pronto el monto a pagar es: " + TotalPagar);


        }
    }
}
