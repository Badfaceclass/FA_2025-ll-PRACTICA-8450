using System;
using T2_Biblioteca2;
using T2_Biblioteca1;
namespace T2_Menú
{
    public class Menu
    {
        public static int ElijeOpcion()
        {
            int opc = 1;
            ConsoleKey tecla;
            while(true) 
            {
                do
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUsa las flechas para moverte y ENTER para elegir");
                    Console.ResetColor();
                    if (opc == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" 1. Venta de pasajes                            ");
                        Console.ResetColor();
                    }
                    else
                    { 
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" 1. Venta de pasajes                            ");
                        Console.ResetColor();

                    }

                    if (opc == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" 2. Equipaje y encomiendas                      ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" 2. Equipaje y encomiendas                      ");
                        Console.ResetColor();

                    }

                    if (opc == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" 3. Gestionar carga                             ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" 3. Gestionar carga                             ");
                        Console.ResetColor();

                    }

                    if (opc == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" 4. Salir del programa                          ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" 4. Salir del programa                          ");
                        Console.ResetColor();

                    }

                    tecla = Console.ReadKey(true).Key;

                    if (tecla == ConsoleKey.UpArrow && opc > 1)
                    {
                        opc--;
                    }

                    if (tecla == ConsoleKey.DownArrow && opc < 4)
                    {
                        opc++;
                    }
                } while (tecla != ConsoleKey.Enter);


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
