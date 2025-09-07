using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey();
        }
        static void ejer1()
        {
            //Declaraciones
            string nombre, carrera;
            
            Console.Write("Ingresa tu nombre: ");
            nombre= Console.ReadLine();
            
            Console.Write("Ingresa tu carrera: ");
            carrera= Console.ReadLine();

            //Mensaje impreso
            Console.WriteLine($"\n{nombre}, Bienvenido al curso de Fundamentos de Algoritmos de la carrera {carrera}");
           

        }
        static void ejer2()
        {
            Console.Write("Ingrese numero x: ");
            int x = int.Parse(Console.ReadLine());
           
            Console.Write("Ingrese numero y: ");
            int y = int.Parse(Console.ReadLine());

            double resu = x / y;

            Console.WriteLine("Suma: " + (x+y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + resu);

        }
        static void ejer3()
        {
            Console.Write("Ingrese un número decimal: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num));
            Console.WriteLine("Redondeo: " + (int)Math.Round(num)); //Esto Redondea al entero más cercano);
            Console.WriteLine("Elevado al cubo: " + Math.Pow(num, 3));
            Console.WriteLine("Raíz cúbica: " + Math.Pow(num, 1/3d));//Math.Pow es la forma de interpretar la elevación de un número ^

        }
        static void ejer4()
        {
            Console.Write("Ingresar número: ");
            string num = Console.ReadLine();

            double deci = double.Parse(num); //Conversión de digito en formato string a double
            int entero = (int)Math.Round(deci);

            Console.WriteLine("Resto de división entre 2 = " + (entero % 2));
            Console.WriteLine("Cociente de división entre 3 = " + (deci / 3));
        }
        static void ejer5()
        {
            Console.Write("Ingresar cantidad en segundos: ");
            int seg = int.Parse(Console.ReadLine());

            //Calculo
            int hora = seg / 3600;
            int minutos = (seg % 3600) / 60;
            int rest = seg % 60;

            Console.WriteLine("Horas: " + hora);
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Segundos restantes: " + rest);
        }
    }
}
