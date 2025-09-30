using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nota, contador, acumulador = 0;
            double promedio;
            for (contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Ingrese la nota  {0}: ", contador +1);
                Nota = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + Nota;

            }
        }
    }
}
