using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            // 4.	Crear un programa para calcular el salario semanal de unos empleados
            // a los que se les paga 15 dólares por hora si éstas no superan las 35 horas.
            // Cada hora por encima de 35 se considerará extra y se paga a 22 dólares. 
            double Horas_Trabajadas;
            double pagado;
            double PagaNormal=0;
            double Horas_Extras;
            double Pago_extra;

            Console.WriteLine(" Por favor ingrese el número de horas trabajadas por el empleado");
            Horas_Trabajadas = double.Parse(Console.ReadLine());
            if (Horas_Trabajadas <= 35)
                pagado = Horas_Trabajadas * 15;
            else
            {
                PagaNormal = 35 * 15;
                Horas_Extras = Horas_Trabajadas - 35;
                Pago_extra = Horas_Extras * 22;
                pagado = PagaNormal + Pago_extra;

            }
            Console.WriteLine(" El pago semanal es : " + pagado + " Dolares");


            Console.ReadKey();
        }

       
            
         
    }
}
