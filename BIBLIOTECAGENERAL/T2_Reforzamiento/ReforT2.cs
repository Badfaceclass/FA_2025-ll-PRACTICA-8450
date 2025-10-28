using System;

namespace ReforzamientoT2
{
    public class ReforT2
    {
        public static void Binvenida(string empleado)
        {
            Console.WriteLine("BIENVENIDO " + empleado + " A SU BOLETA DE PAGO");
        }

        public static double MontoPagar()
        {
            string Cargo;
            int NumHoras;
            double PagoHora = 0;
            double PagoTotal;
            bool Repite = false;

            do
            {
                Console.Write("Ingrese uno de los cargos (OPERARIO/SUPERVISOR/ASISTENTE): ");
                Cargo = Console.ReadLine().ToUpper();

                switch (Cargo)
                {
                    case "OPERARIO":
                        PagoHora = 25.50;
                        Repite = false;
                        break;
                    case "SUPERVISOR":
                        PagoHora = 35;
                        Repite = false;
                        break;
                    case "ASISTENTE":
                        PagoHora = 40.25;
                        Repite = false;
                        break;
                    default:
                        Console.WriteLine("Ingresaste un valor no válido...");
                        Console.WriteLine("Vuelve a ingresar el cargo...");
                        Repite = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (Repite);

            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            NumHoras = Convert.ToInt32(Console.ReadLine());

            PagoTotal = PagoHora * NumHoras;

            return PagoTotal;

        }
    }
}
