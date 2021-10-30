using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JostinAlexanderBajañaBravoNivel3ParaleloBn
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, Mayor = 0, Numeros;
            for(i=0; i < 5; i++)
            {
                Console.WriteLine(" Por favor Digite el número" );
                Numeros = int.Parse(Console.ReadLine());
                if (Numeros > Mayor)
                {
                    Mayor = Numeros;
                }
                
            }
            Console.WriteLine(" El numero mayor es " + Mayor);
            Console.ReadKey();
        }
    }
}
