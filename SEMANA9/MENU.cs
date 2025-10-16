using System;
using OperacionesAritmeticas;

namespace SEMANA9
{
    class MENU
    {
        public static int ElijeOperacion()
        {
            int Numero;

            do
            {
                Console.WriteLine("[1] SUMAR");
                Console.WriteLine("[2] RESTAR");
                Console.WriteLine("[3] MULTIPLICAR");
                Console.WriteLine("[4] DIVIDIR");
                Console.WriteLine("[5] POTENCIA");
                Console.WriteLine("[6] SALIR");

                Console.Write("Ingrese el número de operación (1-6): ");
                Numero = int.Parse(Console.ReadLine());

                if (Numero < 1 || Numero > 6)
                {
                    Console.WriteLine("Ingresó un número no válido, Vuelve a ingresar.");
                    Console.WriteLine("Presione cualquier tecla para continuar....");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Numero < 1 || Numero > 6);

            return Numero;
        }

        private static int IngresaNumero()
        {
            Console.Write("Ingrese el primer número: ");
            int valor1 = int.Parse(Console.ReadLine());            
        }

        //Creamos el método para operar
        public static void EjecutaOperacion(int numero)
        {
            int num1, num2;
            switch (numero)
            {
                case 1:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();

                    //Llamamos a la biblioteca, clase, metodo
                    Console.WriteLine("La suma es: " + Aritmeticas.Sumar(num1, num2));
                    break;
                case 2:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();

                    //Llamamos a la biblioteca, clase, metodo
                    Console.WriteLine("La resta es: " + Aritmeticas.Restar(num1, num2));

                    break;
                case 3:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();

                    //Llamamos a la biblioteca, clase, metodo
                    Console.WriteLine("La multiplicación es: " + Aritmeticas.Multiplica(num1, num2));

                    break;
                case 4:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();

                    //Llamamos a la biblioteca, clase, metodo
                    Console.WriteLine("La suma es: " + Aritmeticas.Divide(num1, num2));

                    break;
                case 5:
                    num1 = IngresaNumero();
                    num2 = IngresaNumero();

                    //Llamamos a la biblioteca, clase, metodo
                    Console.WriteLine("La suma es: " + Aritmeticas.Potencia(num1, num2));

                    break;
                case 6:
                   
                    Console.WriteLine("Gracias por usar mi calculador");
                    Console.WriteLine("Si desea más operaciones adquiera la versión pro.");


                    break;
            }
        }
    }
}
