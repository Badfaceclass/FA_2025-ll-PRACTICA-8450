using System;
namespace Semana9_isaias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio = 16.5;
            double IGV;
            IGV = Operacion.CalculaIGV(precio);
        }
    }
    internal class Operacion
    {
        static double CalculaIGV(double monto)
        {
            return (monto * 0.18);
        }
    }
}
