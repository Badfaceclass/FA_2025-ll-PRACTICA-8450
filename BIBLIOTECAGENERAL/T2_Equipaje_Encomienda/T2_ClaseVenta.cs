using System;

namespace T2_Biblioteca1

{
    public class T2_ClaseVenta
    {
        public static void VentaPasaje()
        {
            int division, dni;
            string nombre, apellido;

            Console.WriteLine("\n--------------------");
            Console.WriteLine("\nIngrese sus datos");
            Console.Write("\nNombre: ");
            nombre = Console.ReadLine();
            Console.Write("\nApellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("\n--------------------");


            while (true)
            {
                int almacen = 0;
                Console.WriteLine("\n--------------------");
                Console.Write("\nDNI: ");
                dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n--------------------");
                division = dni;
                while (division > 0)
                {
                    division = division / 10;
                    almacen++;
                }

                if (almacen < 8 || almacen > 8)
                {
                    Console.WriteLine($"\nError. El dni debe tener 8 dígitos. Vuelva a ingresar.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
            int nroAsiento = 0;
            do
            {
                Console.WriteLine("\n-----------------------");
                Console.Write("\nIngrese numero de asiento (1-30): ");
                nroAsiento = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n-----------------------");

                if (nroAsiento < 1 || nroAsiento > 30)
                {
                    Console.WriteLine("\nIngreso un numero de asiento no valido. Vuelva a ingresar.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (nroAsiento < 1 || nroAsiento > 30);

            Console.WriteLine($"\nNro de Asiento: {nroAsiento}");

            double costoPasaje;

            if (nroAsiento >= 1 && nroAsiento <= 10)
            {
                Console.Clear();
                costoPasaje = 75;
                Console.WriteLine($"\nNombres y apellidos: {nombre} {apellido}");
                Console.WriteLine("\nClase: VIP");
                Console.WriteLine($"\nAsiento {nroAsiento}");
                Console.WriteLine($"\nCosto de pasaje: {costoPasaje}");

            }
            else if (nroAsiento >= 11 && nroAsiento <= 20)
            {
                Console.Clear();
                costoPasaje = 50;
                Console.WriteLine($"\nNombres y apellidos: {nombre} {apellido}");
                Console.WriteLine("\nClase: Ejecutivo");
                Console.WriteLine($"\nAsiento {nroAsiento}");
                Console.WriteLine($"\nCosto de pasaje: {costoPasaje}");

            }
            else
            {
                Console.Clear();
                costoPasaje = 35.50;
                Console.WriteLine($"\nNombres y apellidos: {nombre} {apellido}");
                Console.WriteLine("\nClase: Economico");
                Console.WriteLine($"\nAsiento {nroAsiento}");
                Console.WriteLine($"\nCosto de pasaje: {costoPasaje}");
            }

            Console.WriteLine("\nPresione enter para volver.");
            Console.ReadKey();
        }
        public static void EquipajeEncomienda()
        {
            int equipaje;
            do
            {
                Console.WriteLine("\n--------------------");
                Console.WriteLine("\n1. MALETA");
                Console.WriteLine("\n2. CAJA");
                Console.WriteLine("\n3. BULTO");
                Console.Write("\n Seleccione una de las opciones: ");
                equipaje = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n--------------------");
                if (equipaje != 1 && equipaje != 2 && equipaje != 3)
                {
                    Console.WriteLine("\nTipo de equipaje no valido. Ingrese su equipaje [MALETA/CAJA/BULTO] ");
                }

            } while (equipaje != 1 && equipaje != 2 && equipaje != 3);

            double ancho, largo, alto, peso, MetroCubico;
            do
            {
                Console.Write("\nAncho del equipaje: ");
                ancho = Convert.ToDouble(Console.ReadLine());
                if (ancho < 1)
                {
                    Console.WriteLine("\nError. Ancho no valido vuelva a ingresar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (ancho <= 0);

            do
            {
                Console.Write("\nLargo del equipaje: ");
                largo = Convert.ToDouble(Console.ReadLine());
                if (largo <= 0)
                {
                    Console.WriteLine("\nError. Largo no valido vuelva a ingresar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (largo <= 0);

            do
            {
                Console.Write("\nAlto del equipaje: ");
                alto = Convert.ToDouble(Console.ReadLine());
                if (alto <= 0)
                {
                    Console.WriteLine("\nError. Altura no valida vuelva a ingresar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (alto < 1);

            MetroCubico = (ancho * largo * alto) / 1000;

            do
            {
                Console.Write("\nPeso del equipaje (Limite 25kg): ");
                peso = Convert.ToDouble(Console.ReadLine());
                if (peso < 1)
                {
                    Console.WriteLine("\nError. Excedio el pero o puso un valores no permitidos.");
                }
            } while (peso < 1);

            while (true)
            {
                if (MetroCubico < 0.3 && peso <= 25)
                {
                    Console.WriteLine("\nSu encomienda es ACEPTADA");
                }
                else
                {
                    Console.WriteLine("\nSu encomienda es RECHAZADA. Excedio los limites o puso valores no permitidos.");
                }
                break;
            }
            Console.WriteLine("Presione enter para volver al Menu.");
            Console.ReadKey();
        }
    }
}