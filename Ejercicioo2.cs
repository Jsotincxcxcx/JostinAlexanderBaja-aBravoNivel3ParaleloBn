using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerci2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine(" Por favor Ingrese un número");
            Numero = int.Parse(Console.ReadLine());
            for (int i= 1;i<= Numero; i++)
            {
                for (int Linea = 1; Linea <= Numero; Linea++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");


            }
            Console.ReadKey();

        }
    }
}
