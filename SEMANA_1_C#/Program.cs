using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
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

        }
        static void ejer4()
        {

        }
        static void ejer5()
        {

        }
        static void ejer6()
        {

        }

    }
}
