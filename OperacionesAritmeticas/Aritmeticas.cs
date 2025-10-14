using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public class Aritmeticas
    {
        //Metodo con retorno y parámetros para SUMAR
        public static int Sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        //Metodo con retorno y parámetros para RESTAR
        public static int Restar(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        //Metodo con retorno y parámetros para MULTIPLICACIÓN
        public static int Multiplica(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        //Metodo con retorno y parámetros para DIVICIÓN
        public static int Divide(int valor1, int valor2)
        {
            if(valor2==0)
            {
                Console.WriteLine("No se puede dividir un número entre 0");
                return 0;
            }
            else 
            { 
                return valor1 / valor2; 
            }
            
        }
        //Metodo con retorno y parámetros para POTENCIA
        public static double Potencia(int valor1, int valor2)
        {
            int Contador;
            double Acumulador = 1;
            for (Contador = 1; Contador <= valor2; Contador++)
            {
                Acumulador *= valor1;
            }
            return Acumulador;
        }


    }
}
