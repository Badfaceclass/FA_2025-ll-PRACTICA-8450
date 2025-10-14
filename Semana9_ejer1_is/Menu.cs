using System;
using OperacionesAritmeticas;
namespace Semana9_ejer1_is
{
    class Menu
    {
        public static int ElijeOperacion()
        {
            int Numero;
            do
            {
                Console.WriteLine(" [1] SUMAR");
                Console.WriteLine(" [2] RESTAR ");
                Console.WriteLine(" [3] MULTIPLICAR");
                Console.WriteLine(" [4] DIVIDIR");
                Console.WriteLine(" [5] POTENCIA");
                Console.WriteLine(" [6] SALIR ");

                Console.Write("Ingrese el numero de operacion [1-6]: ");
                Numero = Convert.ToInt32(Console.ReadLine());

                if (Numero < 1 || Numero > 6)
                {
                    Console.WriteLine("Ingreso un numero no valido, vuelva a ingresar.");
                    Console.WriteLine("Preciose cualquier tecla para continuar....."); 
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (Numero < 1 || Numero > 6);
            return Numero;
        }

        //Creamos el metodo para operar

        public static void EjecutaOperacion(int numero)
        {
            int num1, num2;
            switch (numero)
            {
                case 1:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();


                    //Llamos  a la biblioteca, clase, metodo
                    Console.WriteLine($"La suma es: {Aritmeticas.Sumar(num1, num2)}");
                    break;

                case 2:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();
                    Console.WriteLine($"La resta es: {Aritmeticas.Restar(num1, num2)}");
                    break;

                case 3:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();
                    Console.WriteLine($"La divicion es: {Aritmeticas.Multiplicar(num1, num2)}");
                    break;

                case 4:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();
                    Console.WriteLine($"La resta es: {Aritmeticas.Divide(num1, num2)}");
                    break;

                case 5:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();
                    Console.WriteLine($"La resta es: {Aritmeticas.Potencia(num1, num2)}");
                    break;

                case 6:
                    break;
            }
        }
        private static int IngresaNumero()
        {
            Console.Write("Ingrese el primer número: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }

    }
}
