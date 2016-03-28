using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2E10
{
    class Program
    {
        /* 10. Leer dos números flotantes que corresponden a la longitud de los dos catetos de un triángulo 
               rectángulo. Calcular el valor de la hipotenusa y el perímetro del triángulo.

        */
        static void Main(string[] args)
        {
            /**/
            float c1, c2; 
            double h;
            Console.WriteLine("Ingrese el primer Cateto: ");
            c1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo Cateto: ");
            c2 = float.Parse(Console.ReadLine());
            h = Math.Sqrt(Math.Pow(c1,2) +Math.Pow(c2,2));

            Console.WriteLine("Hipotenusa: {0}", h);
            Console.ReadKey();
        }
    }
}
