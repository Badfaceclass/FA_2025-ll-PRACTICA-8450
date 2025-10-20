using System;

namespace Semana10
{
    class Cajero
    {
        private static double saldo = 1000;
        public static int OperacionesBanco()
        {

            int opc;
            Console.WriteLine("Bienvenido al Cajero");
            do
            {
                Console.WriteLine("\n[1]Consultar Saldo");
                Console.WriteLine("[2] Depositar dinero");
                Console.WriteLine("[3] Retirar dinero ");
                Console.WriteLine("[0] Salir");
                Console.Write("\nElija una opcion: ");
                opc = Convert.ToInt32(Console.ReadLine());



                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"Su saldo es: {Consultar()}");
                        break;

                    case 2:
                        Console.Write("Ingrese el monto a depositar (0 para cancelar): ");
                        double Deposito = Convert.ToDouble(Console.ReadLine());
                        Depositar(Deposito);
                        break;

                    case 3:
                        Console.Write("Ingrese el monto a retirar: ");
                        double retiro = Convert.ToDouble(Console.ReadLine());
                        Retirar(retiro);
                        break;

                    case 0:
                        Console.WriteLine("Gracias por usar el cajero.");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;

                }
            } while (opc != 0);

            return opc;
        }
        public static double Consultar()
        {
            return saldo;
        }

        public static void Depositar(double monto)
        {
            while (true) 
            {
                if (monto < 0)
                {
                    Console.WriteLine("No se puede depositar un valor negativo.");
                    Console.Write("Ingrese el monto a depositar (0 para cancelar): ");
                    monto = Convert.ToDouble(Console.ReadLine());
                }
                else if (monto == 0)
                {
                    Console.WriteLine("Depósito cancelado.");
                    return;
                }
                else
                {
                    saldo += monto;
                    Console.WriteLine($"Depósito exitoso. Saldo actual: {saldo}");
                    return; 
                }

            } 
        }

        public static void Retirar (double monto)
        {
            do
            {
                if (monto < 0)
                {
                    Console.WriteLine("\nNo se puede retirar 0 o un valor negativo.");
                    Console.Write("Ingrese nuevamente el monto a retirar: ");
                    monto = Convert.ToDouble(Console.ReadLine());
                }
                else if (monto == 0)
                {
                    Console.WriteLine("Retiro Cancelado.");
                    return;
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("\nNo se puede retirar un monto superior a tu saldo.");
                    Console.Write("Ingrese nuevamente el monto a retirar: ");
                    monto = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    saldo -= monto;
                    Console.WriteLine($"Retiro exitoso. Saldo actual: {saldo}");
                    return;
                }


            } while (true);


        }
    }
}