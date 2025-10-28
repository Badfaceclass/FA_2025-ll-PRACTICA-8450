using System;
using T2_Biblioteca1;
using T2_Biblioteca2;

namespace Pruebas_menu
{
    internal class Menuv2
    {
        public static int Menu2()
        {
            int opc = 1;
            ConsoleKey tecla;
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elija la opcion moviendo las flecha y presionando enter.");

                for (int i = 1; i <= 4; i++)
                {
                    if (opc == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    switch (i)
                    {
                        case 1:
                            Console.WriteLine(" 1. Venta de pasajes                                    ");
                            break;

                        case 2:
                            Console.WriteLine(" 2. Equipaje y Encomienda                               ");

                            break;
                        case 3:
                            Console.WriteLine(" 3. Gestionar carga                                     ");
                            break;
                        case 4:
                            Console.WriteLine(" 4. Salir                                               ");
                                break;
                    }
                    Console.ResetColor();
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow && opc > 1)
                {
                    opc--;
                }

                else if (tecla == ConsoleKey.DownArrow && opc < 4)
                {
                    opc++;
                }
                 
                else if (tecla == ConsoleKey.Enter)
                {
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"\nHas seleccionado la opción [1]: VENTA DE PASAJES");
                            T2_ClaseVenta.VentaPasaje();                           
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine($"\nHas seleccionado la opción [2]: EQUIPAJE Y ENCOMIENDAS");
                            T2_ClaseVenta.EquipajeEncomienda();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine($"\nHas seleccionado la opción [3]: GESTIONAR CARGA");
                            T2_ClaseCarga.GestionCargar();
                            break;

                        case 4:
                            Console.WriteLine("\nSaliendo del programa...");
                            return opc;
                    }
                }
            } 
        }
    }
}
