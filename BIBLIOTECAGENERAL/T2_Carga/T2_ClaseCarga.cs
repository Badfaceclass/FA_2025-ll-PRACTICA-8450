using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Biblioteca2
{
    public class T2_ClaseCarga
    {
        public static void GestionCargar()
        {
            int carga;
            double ancho, alto, largo;
            double metro_cubico = 0, peso = 0, peso_total = 0;
            double limite_volumen = 106.8, volumen_total = 0, limite_peso = 30;
            char Desicion;

            do
            {
                while (true)
                {

                    Console.WriteLine("\n-----------------------------------------");
                    Console.WriteLine("\n1. Alimentos");
                    Console.WriteLine("\n2. Mercadería");
                    Console.WriteLine("\n3. Muebles o varios");
                    Console.WriteLine("\n0. Salir");
                    Console.WriteLine("-----------------------------------------");

                    Console.Write("\nIngrese el tipo de carga a transportar: ");

                    carga = Convert.ToInt32(Console.ReadLine());

                    if (carga < 0 || carga > 3)
                    {
                        Console.WriteLine("\nError. Tipo de carga inválido.Vuelva a elegir.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (carga > 0 && carga <= 3)
                    {
                        Console.WriteLine($"\nUd. ha elegido la opción {carga}");
                        break;
                    }
                    else if (carga == 0)
                    {
                        return;
                    }
                }

                Console.WriteLine("\nIngrese las dimensiones de la carga en metros.");
                do
                {

                    Console.Write("\nAncho (max: 2.40 metros): ");
                    ancho = Convert.ToDouble(Console.ReadLine());

                    if (ancho < 0 || ancho > 2.40)
                    {
                        Console.WriteLine("\nError. El valor ingresado no es válido. Vuelva a ingresar.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"\nUd. ha ingresado un ancho de {ancho} metros.");
                    }
                } while (ancho < 0 || ancho > 2.40);


                do
                {
                    Console.Clear();
                    Console.WriteLine($"\nUd. ha ingresado un ancho de {ancho} metros.");
                    Console.Write("\nAlto (max: 3.4 metros): ");
                    alto = Convert.ToDouble(Console.ReadLine());
                    if (alto < 0 || alto > 3.4)
                    {
                        Console.WriteLine("\nError. El valor ingresado no es válido.Vuelva a ingresar.");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine($"\nUd. ha ingresado un alto de {alto} metros.");
                    }
                } while (alto < 0 || alto > 3.4);

                do
                {
                    Console.Clear();
                    Console.Write("\nLargo (max: 13 metros): ");
                    largo = Convert.ToDouble(Console.ReadLine());
                    if (largo < 0 || largo > 13)
                    {
                        Console.WriteLine("\nError. El valor ingresado no es válido. Vuelva a ingresar.");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine($"\nUd. ha ingresado un ancho de {ancho} metros.");
                        Console.WriteLine($"\nUd. ha ingresado un alto de {alto} metros.");
                        Console.WriteLine($"\nUd. ha ingresado un largo de {largo} metros.");
                    }
                } while (largo < 0 || largo > 13);

                metro_cubico = ancho * alto * largo;

                do
                {
                    Console.Clear();
                    Console.WriteLine($"\nUd. ha ingresado un ancho de {ancho} metros.");
                    Console.WriteLine($"\nUd. ha ingresado un alto de {alto} metros.");
                    Console.WriteLine($"\nUd. ha ingresado un largo de {largo} metros.");
                    Console.Write("\nIngrese el peso de la carga (max: 30 toneladas): ");
                    peso = Convert.ToDouble(Console.ReadLine());

                    if (peso > 0 && peso <= 30)
                    {
                        Console.WriteLine($"\nUd. ha ingresado un peso de {peso} toneladas.");

                    }
                    else
                    {
                        Console.WriteLine("\nError. El valor ingresado no es válido.");
                    }
                } while (peso <= 0 || peso > 30);

                if ((volumen_total + metro_cubico) <= limite_volumen && (peso_total + peso) <= limite_peso)
                {
                    Console.Clear();
                    peso_total += peso;
                    volumen_total += metro_cubico;

                    Console.WriteLine($"\nVolumen acumulado: {volumen_total} m³");
                    Console.WriteLine($"\nPeso acumulado: {peso_total} toneladas");
                }
                else
                {
                    Console.WriteLine("\nNo se puede transportar más carga. Se alcanzaron los límites permitidos.");
                    Console.WriteLine("No puede llevar esta carga.");
                }
                while (true)
                {
                    Console.Write("¿Desea ingresar otra carga? (s/n): ");
                    Desicion = char.ToLower(Convert.ToChar(Console.ReadLine()));

                    if (Desicion == 's')
                    {
                        Console.Clear();
                        break;
                    }
                    else if (Desicion == 'n')
                    {
                        Console.Clear();
                        Console.WriteLine($"\nVolumen final: {volumen_total} m³");
                        Console.WriteLine($"\nPeso final: {peso_total} toneladas");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Solo se acepta (s/n).");
                    }
                }
            } while (carga > 0 && carga < 4);
        }
    }
}
