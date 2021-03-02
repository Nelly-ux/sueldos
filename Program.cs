using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUEN DÍA PERSONA TRABAJADORA!!");
            Console.WriteLine("¿Quiere usted calcular su sueldo?");
            Console.WriteLine("1. SI"); 
            Console.WriteLine("2. NO");

            int a;
            a = int.Parse(Console.ReadLine()); 

            if (a==1)
            {
                Console.WriteLine("Ingrese horas trabajadas:");
                float ht = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su sueldo por hora:");
                float sh = float.Parse(Console.ReadLine());

                float res;

                res = ht * sh;
                Console.WriteLine("su sueldo total es:"+res);

                Console.WriteLine("¿Quiere usted calcular su sueldo?");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");
                a = int.Parse(Console.ReadLine());


            }
            else if (a==2)
            {
                Console.WriteLine("OK");
                Console.WriteLine("¿Quiere usted calcular su sueldo?");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");
                a = int.Parse(Console.ReadLine());
            }

            Console.ReadKey() ;
        }
    }
}
