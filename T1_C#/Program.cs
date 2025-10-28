using System;

namespace T1_Ju
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int edad, tiempo, Riesgo = 0;
            double credito, sueldo, prestamo;

            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18 && edad <= 25)
            {
                Riesgo = 1;
            }
            else if (edad > 25 && edad <= 35)
            {
                Riesgo = 2;
            }
            else if (edad > 35 && edad <= 50)
            {
                Riesgo = 3;
            }
            else if (edad > 50 && edad <= 65)
            {
                Riesgo = 4;
            }
            else if (edad > 65)
            {
                Riesgo = 5;
            }
            switch (Riesgo)
            {
                case 1:
                    Console.WriteLine("Riesgo: alto");
                    Console.Write("¿Cual es su tiempo Trabajando?: ");
                    tiempo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("¿Cual es su Sueldo?: ");
                    sueldo = Convert.ToInt32(Console.ReadLine());
                    if (tiempo > 8 && sueldo > 1500)
                    {
                        Console.WriteLine("Es apto para recibir Tarjeta de credito");
                        credito = sueldo * 0.75;
                        Console.WriteLine($"Su credito recibido es: {credito}");
                    }

                    break;

                case 2:
                    Console.WriteLine("Riesgo: Moderado Alto");
                    Console.Write("¿Cual es su tiempo Trabajando?: ");
                    tiempo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("¿Cual es su Sueldo?: ");
                    sueldo = Convert.ToInt32(Console.ReadLine());
                    if (tiempo > 4 && sueldo > 4500)
                    {
                        Console.WriteLine("Es apto para recibir Tarjeta de credito");
                        credito = sueldo * 1.2;
                        Console.WriteLine($"Su credito recibido es: {credito}");
                        prestamo = 10000;
                    }
                    else if (2500 < sueldo && sueldo < 4000)
                    {
                        Console.WriteLine("Es apto para recibir Tarjeta de credito");
                        credito = sueldo * 0.8;
                        Console.WriteLine($"Su credito recibido es: {credito}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Riesgo: Moderado Medio");
                    Console.Write("¿Cual es su Sueldo?: ");
                    sueldo = Convert.ToInt32(Console.ReadLine());
                    if (sueldo > 8500)
                    {
                        Console.WriteLine("Es apto para recibir Tarjeta de credito");
                        credito = sueldo * 1.5;
                        Console.WriteLine($"Su credito recibido es: {credito}");
                        prestamo = 20000;
                    }
                    else if (6000 < sueldo && sueldo < 8500)
                    {
                        Console.WriteLine("Es apto para recibir Tarjeta de credito");
                        credito = sueldo * 1.3;
                        Console.WriteLine($"Su credito recibido es: {credito}");
                    }
                    else
                    {
                        prestamo = 15000;

                    }
                    break;

                case 4:
                    Console.WriteLine("Riesgo: Bajo");
                    Console.Write("¿Cual es su tiempo Trabajando?: ");
                    tiempo = Convert.ToInt32(Console.ReadLine());
                    if (tiempo >= 10)
                    {
                        Console.WriteLine("Es apto para recibir Tarjeta de credito");
                        credito = 25000;
                        Console.WriteLine($"Su credito recibido es: {credito}");
                        prestamo = 50000;
                    }
                    else if (tiempo < 5 && tiempo < 9)
                    {
                        Console.WriteLine("Es apto para recibir Tarjeta de credito");
                        credito = 18000;
                        Console.WriteLine($"Su credito recibido es: {credito}");
                        prestamo = 40000;
                    }
                    else
                    {
                        prestamo = 30000;

                    }
                    break;

                case 5:
                    Console.WriteLine("Riesgo: Precaucion");
                    char propiedad;
                    Console.Write("¿Ud. Tiene Propiedades? S/N:");
                    propiedad = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (propiedad == 'S')
                    {
                        double valor;
                        Console.Write("Valorarizacion de su propiedad: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        prestamo = valor * 0.3;
                    }
                    else if (propiedad == 'N')
                    {
                        Console.WriteLine("No es apto para recibir Tarjeta de credito");
                        Console.WriteLine("No es apto para recibir prestamo.");
                    }
                    break;

                default:
                    Console.WriteLine("Error. La edad no puede ser nagativa.");
                    break;
            }
        }
    }
}
