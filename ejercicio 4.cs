using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI, PR, PT, DV,D,DT;
            D = 0;
            DT = 0;
            Console.WriteLine("Cuanto cuesta el pasaje de ida");
            PI = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto cuesta el pasaje de regreso");
            PR = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos dias viaja a la semana");
            DV = double.Parse(Console.ReadLine());

            PT = (PI + PR) * DV;
            if (PT > 199)
            {
                Console.WriteLine("Obtiene un apoyo universitario de 100");
                D= 100;
                DT = PT - D;
            }
            else
                if (PT >= 150 )
                {
                Console.WriteLine("obtiene un un apoyo de 50 pesos");
                D = 50;
                DT = PT - D;
                }
                else

                {
                 Console.WriteLine("no tiene apoyo");
           
                }
            Console.WriteLine("LO QUE GASTA DE PASAJE A LA SEMANA SIN APOTYO ES: "+ PT);
            Console.WriteLine("EL APOYO BRINDADO ES DE: " + D );
            Console.WriteLine("LO QUE GASTARA A ALA SEMANA SERA" + DT );
            Console.ReadKey();
            
        }
    }
}
