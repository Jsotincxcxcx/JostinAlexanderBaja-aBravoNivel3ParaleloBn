using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // rear el programa asteriscos4 en el que se introduce un número entero
            // y se crea una pirámide de asteriscos.
            // Por ejemplo, si se introduce el 6, el resultado sería:
            int Numero;
       
            Console.WriteLine(" Por favor introduzca un número ");
            Numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Numero; i++)
            {
                

                for (int line = 1; line <= Numero - i; line++)
                {
                    Console.Write(" ");
                    
                }

                for (int line = 1; line <= i ; line++)
                {
                    Console.Write("*");

                }
                for (int line = 1; line <= i - 1; line++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
