using System;
using ReforzamientoT2;

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

            ReforT2.Binvenida(Nombre);

            TotalPagar = ReforT2.MontoPagar();

            Console.WriteLine("Por lo pronto el monto a pagar es: " + TotalPagar);

        }
    }
}
