using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSumaDosNumeros
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //declaracion de variables
            int numero1, numero2, suma;
            string linea;
            Console.WriteLine("*:programa que calcula la suma de 2 numeros:...*");
            Console.WriteLine("Dijite Numero 1");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("Dijite Numero 2");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);
            suma = numero1 + numero2;
            Console.WriteLine("la suma es :" + suma);
            Console.WriteLine("");
            Console.WriteLine("*me impresionas tu forma de programar*");
            Console.ReadKey();
        }
    }
}
