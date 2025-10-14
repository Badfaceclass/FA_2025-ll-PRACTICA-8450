using System;

namespace Semana9_ejer1_is
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Operacion;
            Console.WriteLine("---------Ejercicio tipo examen----------");
            Operacion = Menu.ElijeOperacion();
            Console.WriteLine($"El valor que ingreso es: {Operacion}");

            Menu.EjecutaOperacion(Operacion);
        }
    }
}