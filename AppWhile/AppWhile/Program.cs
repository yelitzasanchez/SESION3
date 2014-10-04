using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*una fabrica que fabica perfiles de hierro posee 
             *un lote de n piezas. confeccionar un programa 
             *que pida ingresar por teclado la cantidad de 
             *piezas a poseer y luego ingrese la longitud de cada perfil 
             *sabiendo que la pieza de cuya longitud este comprometida
             * n el rango de 1,20 y 1,30 son aptas. imprimir por pantalla
             * la cantidad de piezas aptas que hay en el lote */
            int piezas, contador = 1;
            float longitud;
            Console.WriteLine("programa fabrica de perfiles");
            Console.WriteLine("lea numero de piezas");
            piezas = int.Parse(Console.ReadLine());

            while (contador <= piezas)
            {
                Console.WriteLine("lea longuitud");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    Console.WriteLine("la pieza" + longitud + "es apta");
                    contador++;
                }
                else
                {
                    Console.WriteLine("la pieza" + longitud + "no es apta");
                    contador++;
                }
            }
            Console.ReadKey();

        }
    }
}
