using System;
namespace OperacionesAritmeticas
{
    public class Aritmeticas
    {
        //Metodo con retorno y parametros para SUMAR
        public static int Sumar(int valor1, int valor2)
        {
            return (valor1 + valor2);
        }
        //Metodo con retorno y parametros para Restar
        public static int Restar(int valor1, int valor2)
        {
            return (valor1 - valor2);
        }
        //Metodo con retorno y parametros para Multiplicar
        public static double Multiplicar(int valor1, int valor2)
        {
            return (valor1 * valor2);
        }
        //Metodo con retorno y parametros para Dividir
        public static double Divide(int valor1, int valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("No se puede dividir un numero entre 0");
                return 0;
            }
            else
            {
                return (valor1 / valor2);
            }
        }
        public static double Potencia(int valor1, int valor2)
        {
            int Contador = 1;
            double Acumulador = 1;

            for (Contador = 1; Contador <= valor2; Contador++) 
            {
                Acumulador  *= valor1 ;
            }
            return Acumulador;

        }
    }
}
 //Al ser Biblioteca no se ejecuta, lo debemos copilar 
 //Creamos el archivo dll