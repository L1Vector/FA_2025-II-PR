using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Operacion;
            
            Console.WriteLine("-----EJERCICIO TIPO EXAMEN-----");

            Operacion = MENU.ElijeOperacion();

            MENU.EjecutaOperacion( Operacion );
        }
    }
}
