using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            // 8.	Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas.
            // La primera cuenta desde uno hasta el número escrito contando de uno en uno;
            // la segunda columna cuenta de dos en dos y la tercera de tres. 
            int Numero;
            int Conta = 0;
            int conta2 = 0;
            int conta3 = 0;
            Console.WriteLine("Por favor ingrese el numero entero");
            Numero = int.Parse(Console.ReadLine());
            for  (int i=0;i< Numero; i++)
            {
                Conta++;
                conta2=conta2+2;
                conta3=conta3+3;
                
                Console.WriteLine(" " + Conta + " " + conta2 + " " + conta3);

            } 
            
            Console.ReadKey();
        }
    }
}
