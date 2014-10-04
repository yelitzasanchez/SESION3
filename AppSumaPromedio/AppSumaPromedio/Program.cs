using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSumaPromedio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num1, num2, num3, num4, pro, sum;
            Console.WriteLine("calcular la suma y el promedio de 4 numeros :");
            Console.WriteLine("Dijite Numero 1");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dijite Numero 2");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dijite Numero 3");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dijite Numero 4");
            num4 = double.Parse(Console.ReadLine());
            sum = num1 + num2 + num3 + num4;
            Console.WriteLine("la suma es :" + sum);
            pro = sum / 4;
            Console.WriteLine("promedio es :" + pro);
            Console.WriteLine("");
            Console.WriteLine("la suma de los 4 numeros es :" + sum + "    y el promedio es :" + pro);
            Console.ReadKey();
        }
    }
}
