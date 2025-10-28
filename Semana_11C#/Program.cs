using System;
using System.Runtime.ConstrainedExecution;

namespace Semana_11C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            ConsoleKey tecla;
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elija la opcion moviendo las flecha y presionando enter.");
                Console.ResetColor();
                for (int i = 1; i <= 14; i++)
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
                            Console.WriteLine(" 1. EjerMio                                             ");
                            break;

                        case 2:
                            Console.WriteLine(" 2. Ejemeplo 1                                          ");

                            break;
                        case 3:
                            Console.WriteLine(" 3. Ejemeplo 2                                          ");
                            break;
                        case 4:
                            Console.WriteLine(" 4. Ejemeplo 3                                          ");
                            break;
                        case 5:
                            Console.WriteLine(" 5. Ejemeplo 4                                          ");
                            break;

                        case 6:
                            Console.WriteLine(" 6. Ejercicio 1                                         ");
                            break;

                        case 7:
                            Console.WriteLine(" 7. Ejercicio 2                                         ");
                            break;

                        case 8:
                            Console.WriteLine(" 8. Ejercicio 3                                         ");
                            break;
                        case 9:
                            Console.WriteLine(" 9. Ejercicio 4                                         ");
                            break;

                        case 10:
                            Console.WriteLine(" 10. Ejercicio 5                                        ");
                            break;

                        case 11:
                            Console.WriteLine(" 11. Ejercicio 6                                        ");
                            break;

                        case 12:
                            Console.WriteLine(" 12. Ejercicio 7                                        ");
                            break;

                        case 13:
                            Console.WriteLine(" 9. Ejercicio 8                                         ");
                            break;

                        case 14:
                            Console.WriteLine(" 10. Salir                                              ");
                            break;
                    }
                    Console.ResetColor();
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow && opc > 1)
                {
                    opc--;
                }

                else if (tecla == ConsoleKey.DownArrow && opc < 14)
                {
                    opc++;
                }

                else if (tecla == ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine($"Has seleccionado la opción [1]: EjerMio\n");
                            EjerMio();
                            break;
                        case 2:
                            Console.WriteLine($"\nHas seleccionado la opción [2]: EJEMPLO 1");
                            Ejemplo1();
                            break;

                        case 3:
                            Console.WriteLine($"\nHas seleccionado la opción [3]: EJEMPLO 2");
                            Ejemplo2();
                            break;

                        case 4:
                            Console.WriteLine($"\nHas seleccionado la opción [4]: EJEMPLO 3");
                            Ejemplo3();
                            break;

                        case 5:
                            Console.WriteLine("\nHas seleccionado la opción [5]: EJEMPLO 4");
                            Ejemplo4();
                            break;

                        case 6:
                            Console.WriteLine("\nHas seleccionado la opción [6]: 1 - Ejercicio");
                            Ejercicio1();
                            break;

                        case 7:
                            Console.WriteLine("\nHas seleccionado la opción [7]: 2 - Ejercicio");
                            Ejercicio2();
                            break;

                        case 8:
                            Console.WriteLine("\nHas seleccionado la opción [8]: 3 - Ejercicio");
                            Ejercicio3();
                            break;

                        case 9:
                            Console.WriteLine("\nHas seleccionado la opción [9]: 4 - Ejercicio");
                            Ejercicio4();
                            break;

                        case 10:
                            Console.WriteLine("\nHas seleccionado la opción [10]: 5 - Ejercicio");
                            Ejercicio5();
                            break;

                        case 11:
                            Console.WriteLine("\nHas seleccionado la opción [11]: 6 - Ejercicio");
                            Ejercicio6();
                            break;

                        case 12:
                            Console.WriteLine("\nHas seleccionado la opción [12]: 7 - Ejercicio");
                            Ejercicio7();
                            break;

                        case 13:
                            Console.WriteLine("\nHas seleccionado la opción [13]: 8 - Ejercicio");
                            break;

                        case 14:
                            Console.WriteLine(" Saliendo......                                            ");
                            return;
                    }
                }
            }
        }
        static void EjerMio()
        {
            int[] ArregloEdad = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese la edad {i}: ");
                ArregloEdad[i] = Convert.ToInt32(Console.ReadLine());


                if (i == 4)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(ArregloEdad[j]);

                    }
                }
            }

        }
        static void Ejemplo1()
        {
            //byte Edad;

            //Declarando un arreglo
            byte[] Edades;

            //Asignar un tamaño al arreglo
            //Edades = new byte[5];

            string[] nombres = new string[5];

            int CantidadPersonas;

            Console.Write("Ingrese la cantidad de personas: ");
            CantidadPersonas = Convert.ToInt32(Console.ReadLine());

            Edades = new byte[CantidadPersonas];

        }
        static void Ejemplo2()
        {
            string[] Nombre = new string[5] { "Juan", "Ricardo", "Maria", "Job", "Leo" };

            int[] Edades = new int[] { 1, 2, 3, 4, 5 };

            double[] Precio = { 25.5, 20, 15.30, 41 };

            string[] Apellidos = new string[5];

            for (int i = 0; i < Apellidos.Length; i++)
            {
                Console.Write("Ingrese su apellido {0}: ", i);
                Apellidos[i] = Console.ReadLine();
            }

        }

        static void Ejemplo3()
        {
            string[] Nombre = new string[5] { "Juan", "Ricardo", "Maria", "Job", "Leo" };
            string[] Apellidos = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese su apellido N°{i}: ");
                Apellidos[i] = Console.ReadLine();

                if (i == 4)
                {
                    Console.Clear();
                    for (int j = 0; j < Apellidos.Length; j++)
                    {

                        Console.WriteLine($"Nombre: {Nombre[j]} - Apellido: {Apellidos[j]}\n");
                    }

                }

            }
        }
        static void Ejemplo4()
        {

            char[] Letras = { 'a', 'e', 'i', 'o', 'u' };
            char Ingreso;

            while (true)
            {
                Console.Clear();
                Console.Write("Ingrese una vocal: ");
                Ingreso = Convert.ToChar(Console.ReadLine().ToLower());

                bool esVocal = false;

                foreach (char letra in Letras)
                {
                    if (Ingreso == letra)
                    {
                        esVocal = true;
                        break;
                    }
                }

                if (esVocal)
                {
                    Console.WriteLine("¡Correcto! Has ingresado una vocal.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("¡Error! No has ingresado una vocal.");
                    Console.ReadKey();

                }


            }
           
        }
        static void Ejercicio1()
        {

            int[] num = new int[5];
            
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese numero {i+1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nLista de numeros ingresados: ");

            foreach (int i in num)
            {
                Console.Write(i+" ");
            }

        }
        static void Ejercicio2()
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };
            Console.WriteLine("Lista origian: ");
            foreach (int i in num)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nLista con reemplazos: ");
            for (int i = 0;i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    num[i] = 0;
                    Console.Write(num[i] + " ");
                }
            }
            Console.ReadKey();

        }
        static void Ejercicio3()
        {
            int[] num = { 10, 50, 6, 3, 7, 20 };

            int max = num [0];
            int min = num [0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < max)
                {
                    max = num[i];
                }
                if (num[i] > min)
                {
                    min = num[i];
                }
            }
            Console.ReadKey();
        }
        static void Ejercicio4()
        {
            int [] num = new int [10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese numero {i+1}: ");
                num[i] = int.Parse (Console.ReadLine());
            }
            Console.WriteLine("\nLista de pares: ");
            for (int i = 0; i < num.Length ; i++)
            {
                if (num[i] %2 == 0)
                {
                    Console.Write(num[i]);   
                }
            }
            Console.ReadKey();


        }
        static void Ejercicio5()
        {
            Console.Write("Ingrese la cantidad de numeros: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int [cant];
            int suma = 0;

            for(int i = 0; i < cant; i++)
            {
                Console.Write($"Ingrese numero {i+1}: ");
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i];
            }
            Console.Write("\nNumeros ingresados: ");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nLa suma total es: {suma}");
            Console.ReadKey();
        }
        static void Ejercicio6()
        {
            string[] productos = new string [5];
            int registro = 0;

            for (int i = 0; i < productos.Length; i++)
            {
                Console.Write ("Ingrese producto: ");
                string pro = Console.ReadLine();
                bool repe = false;

                for (int j = 0; j < productos.Length; j++)
                {
                    if (productos[j] == pro)
                    {
                        Console.WriteLine("Producto ya existente. \n");
                        repe = true;
                        break;
                       
                    }
                }
                if (repe == false)
                {
                    productos[registro] = pro;
                    registro++;
                }
            }
            Console.WriteLine("\nLista de productos: ");
            foreach(string i in productos)
            {
                Console.WriteLine("-"+i);
            } 
            Console.ReadKey ();
        }
        static void Ejercicio7()
        {
            Console.Write("Ingrese la cantidad de numeros: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            Random rnd = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(1, 51);
                Console.WriteLine(num[i]);
            }
            Console.Write("\nIngrese el numero a buscar: ");
            int buscar = int.Parse(Console.ReadLine());
            bool b =false;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == buscar)
                {
                    b = true;
                }
            }
            if (b = true)
            {
                Console.WriteLine("Existe.");
            }
            else
            {
                Console.WriteLine("No existe");
            }
            Console.ReadKey();

        }

    }
}
