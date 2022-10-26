using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECAS
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio = 0;

            Console.WriteLine("ingresa el promedio y determina si recibe o no  la beca");
            Console.WriteLine("ingresa calificaciones optenidas ");
            promedio = double.Parse(Console.ReadLine());

            if (promedio > 9.5 && promedio <= 10)
            {
                Console.WriteLine("tiene  beca de exelencia ");
            }
            else
            
                if (promedio > 9 && promedio <= 9.5)
            {
                Console.WriteLine("tienes beca alimenticia ");
            }
            
            else 
            
                if (promedio > 8.5 && promedio <= 9)
            {
                Console.WriteLine("tiene beca de trasporte");
            }
                 
            else
                if (promedio >= 8 && promedio <= 8.5)
                 {
                          Console.WriteLine(" no tiene beca ");
                 }
            else 
                 if (promedio < 8)
                 {
                      Console.WriteLine("esta reprobado");

                 }

            Console.ReadKey();

        }
    }
}


