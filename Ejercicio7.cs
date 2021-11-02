using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {

            // 7.	Crear un programa que escriba dos columnas de números,
            // en la primera se colocan los números del 1 al 100, en la segunda los números del 100 al 1 
            int Linea = 100;
            int conta = 0;
            int conta2 =101;
            for (int i = 0; i < Linea; i++)
            {
                conta++;
                conta2--;
                Console.WriteLine(" "+conta+" "+conta2);
            }
            Console.ReadKey();
        }
    }
}
