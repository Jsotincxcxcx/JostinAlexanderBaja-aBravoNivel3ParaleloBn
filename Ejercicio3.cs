using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int Cantidad;
            double Precios;
            double Total ;
            double Contador = 0;
            Console.WriteLine(" Por favor introduzca la cantidad vendida");
            Cantidad = int.Parse(Console.ReadLine()); 
            if (Cantidad > 0)
            {
                for (int i = 1; i <= Cantidad; i++)
                {
                    Console.WriteLine(" Por favor ingrese el precio ");
                    Precios = double.Parse(Console.ReadLine());
                    Contador = Precios + Contador;
                }
            }          
            Total = Contador;           
            Console.WriteLine(" El total de la factura es : " + Total);
            Console.WriteLine(" Vuelva pronto cabeza de tula * Lo queremos :) * ");
          Console.ReadKey();
        }
        
    }
}
