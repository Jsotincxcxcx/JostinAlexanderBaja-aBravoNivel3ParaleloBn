using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Ejercicio9
    {
        static void Main(string[] args)
        {

            // 9.	Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15.
            int Tabla1 = 1;
            int conta = 0;
            int segundo = 0;
            int Multi = 0;
            for (int i = 0; i < 15; i++)
            {
                conta++;
                segundo++;
                Multi = conta*1;
                Console.WriteLine(+Tabla1+ "  x  " + segundo + " = " + conta);
            }
            Console.ReadKey();
        }
    }
}
